using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Tools
{
    public class BuildersHamaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Builder's Hamaxe");
        }

        public override void SetDefaults()
        {
            item.damage = 1;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 3;
            item.useAnimation = 3;
            item.axe = 300;
            item.hammer = 1500;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 100);
            recipe.AddIngredient(ItemID.StoneBlock, 100);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}