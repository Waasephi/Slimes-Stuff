using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Blocks
{
	public class CrimsonAltar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fake Crimson Altar");
			Tooltip.SetDefault("Places a fake crimson altar to act as a crafting station.");
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
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.value = 0;
			item.createTile = mod.TileType("CrimsonAltar");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.HeavyWorkBench);
			recipe.AddIngredient(ItemID.CrimtaneBar, 20);
			recipe.AddIngredient(ItemID.CrimstoneBlock, 50);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}