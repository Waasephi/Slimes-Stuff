using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Magic
{
    public class StarWand : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Star Wand");
            Tooltip.SetDefault("Fires a shooting star.");
            Item.staff[item.type] = true;
        }
        public override void SetDefaults()
        {
            item.damage = 35;
            item.magic = true;
            item.width = 20;
            item.height = 20;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 1;
            item.knockBack = 2;
            item.value = 100;
            item.rare = 6;
            item.UseSound = SoundID.Item43;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("StarWandProjectile");
            item.shootSpeed = 7f;
            item.mana = 5;
            item.noMelee = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BeeGun, 1);
            recipe.AddIngredient(ItemID.Vilethorn, 1);
            recipe.AddIngredient(ItemID.AquaScepter, 1);
            recipe.AddIngredient(ItemID.Flamelash, 1);
            recipe.AddTile(26);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}