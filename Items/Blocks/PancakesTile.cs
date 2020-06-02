using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Items.Blocks
{
	public class PancakesTile : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pancakes (Placeable)");
		}

		public override void SetDefaults()
		{
			item.width = 40;
			item.height = 30;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.value = 0;
			item.createTile = mod.TileType("Pancakes");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "Pancakes");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}