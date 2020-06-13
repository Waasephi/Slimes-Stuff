using OurStuffAddon.Items.Consumables.Potions;
using OurStuffAddon.Tiles.Misc;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Blocks
{
	public class PancakesPlaceable : ModItem
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
			item.createTile = ModContent.TileType<PancakesTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Pancakes>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}