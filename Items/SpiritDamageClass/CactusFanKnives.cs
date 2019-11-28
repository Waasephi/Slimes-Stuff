using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.SpiritDamageClass
{
    // This class handles everything for our custom damage class
    // Any class that we wish to be using our custom damage class will derive from this class, instead of ModItem
 
	public class CactusFanKnives : SpiritDamageItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cactus Fan Knives");
            Tooltip.SetDefault("[c/00f2ff:-Spirit Class-]");
            Item.staff[item.type] = true;
        }
        // Called when the mod loads, so our changes are added to the game
        public static void AddHacks()
        {
            // Set ourselves to be ranged temporarily to benefit from ranged bonuses
            // This is needed because terraria changes the variables before calling tML's method
            // based on if the item was set to be ranged. Ours isn't, but we still want our custom bow
            // to benefit from ranged bonuses, despite being an Example damage weapon.
            // This is how to do it.
            On.Terraria.Player.GetWeaponDamage += PlayerOnGetWeaponDamage;
            On.Terraria.Player.GetWeaponKnockback += PlayerOnGetWeaponKnockback;
        }

        private static float PlayerOnGetWeaponKnockback(On.Terraria.Player.orig_GetWeaponKnockback orig, Player self, Item sitem, float knockback)
        {
            bool isSpiritCaster = sitem.type == ModContent.ItemType<CactusFanKnives>();
            if (isSpiritCaster) sitem.ranged = true;

            float kb = orig(self, sitem, knockback);
            if (isSpiritCaster) sitem.ranged = false;
            return kb;
        }

        private static int PlayerOnGetWeaponDamage(On.Terraria.Player.orig_GetWeaponDamage orig, Player self, Item sitem)
        {
            bool isSpiritCaster = sitem.type == ModContent.ItemType<CactusFanKnives>();
            if (isSpiritCaster) sitem.ranged = true;

            int dmg = orig(self, sitem);
            if (isSpiritCaster) sitem.ranged = false;
            return dmg;
        }

        // Our ExampleDamageItem abstract class handles all code related to our custom damage class
        public override void SafeSetDefaults()
        {
            item.shootSpeed = 5f;
            item.shoot = 336;
            item.UseSound = SoundID.Item1;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.noMelee = true;
            item.Size = new Vector2(18, 46);
            item.damage = 3;
            item.crit = 2;
            item.knockBack = 2;
            item.autoReuse = true;
            item.rare = 7;
        }

        public override void GetWeaponCrit(Player player, ref int crit)
        {
            // It is hard to hook into every place checking item's crit and fake item.ranged = true
            // Instead, we can mimick regular ranged crit assignment
            crit = Main.LocalPlayer.rangedCrit - Main.LocalPlayer.inventory[Main.LocalPlayer.selectedItem].crit + Main.HoverItem.crit;
            base.GetWeaponCrit(player, ref crit);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Cactus, 50);
            recipe.AddIngredient(ItemID.PinkPricklyPear);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 4 + Main.rand.Next(6); // 1 or 4 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(45)); // 20 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                 float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                 perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
    }
}