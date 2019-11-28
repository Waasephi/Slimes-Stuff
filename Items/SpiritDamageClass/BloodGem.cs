using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.SpiritDamageClass
{
    // This class handles everything for our custom damage class
    // Any class that we wish to be using our custom damage class will derive from this class, instead of ModItem
 
	public class BloodGem : SpiritDamageItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blood Gem");
            Tooltip.SetDefault("[c/00f2ff:-Spirit Class-]");
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
            bool isSpiritCaster = sitem.type == ModContent.ItemType<BloodGem>();
            if (isSpiritCaster) sitem.ranged = true;

            float kb = orig(self, sitem, knockback);
            if (isSpiritCaster) sitem.ranged = false;
            return kb;
        }

        private static int PlayerOnGetWeaponDamage(On.Terraria.Player.orig_GetWeaponDamage orig, Player self, Item sitem)
        {
            bool isSpiritCaster = sitem.type == ModContent.ItemType<BloodGem>();
            if (isSpiritCaster) sitem.ranged = true;

            int dmg = orig(self, sitem);
            if (isSpiritCaster) sitem.ranged = false;
            return dmg;
        }

        // Our ExampleDamageItem abstract class handles all code related to our custom damage class
        public override void SafeSetDefaults()
        {
            item.shootSpeed = 20f;
            item.shoot = 304;
            item.UseSound = SoundID.Item43;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.noMelee = true;
            item.Size = new Vector2(18, 46);
            item.damage = 20;
            item.crit = 2;
            item.knockBack = 2;
            item.autoReuse = true;
            item.rare = 9;
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
            recipe.AddIngredient(mod, "SpiritGem", 1);
            recipe.AddIngredient(ItemID.CrimtaneBar, 20);
            recipe.AddTile(mod, "SpiritInfuser");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}