using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Blocks
{
    public class DemonAltar : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fake Demon Altar");
            Tooltip.SetDefault("Places a fake demon altar to act as a crafting station.");
        }


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
            item.createTile = mod.TileType("DemonAltar");
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.AddIngredient(ItemID.DemoniteBar, 20);
            recipe.AddIngredient(ItemID.EbonstoneBlock, 50);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}