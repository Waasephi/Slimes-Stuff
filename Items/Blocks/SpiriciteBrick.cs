using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Blocks
{
    public class SpiriciteBrick : ModItem
    {



        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 16;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 0;
            item.createTile = mod.TileType("SpiriciteBrick");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddTile(mod, "SpiritInfuser");
            recipe.AddIngredient(null, "SpiritShard", 1);
            recipe.AddIngredient(3, 50);
            recipe.SetResult(this, 50);
            recipe.AddRecipe();
        }

    }
}