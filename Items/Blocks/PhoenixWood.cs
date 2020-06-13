using Terraria.ModLoader;

namespace OurStuffAddon.Items.Blocks
{
	public class PhoenixWood : ModItem
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
			item.createTile = mod.TileType("PhoenixWood");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddTile(18);
			recipe.AddIngredient(ModContent.ItemType<PhoenixWoodPlatform>(), 2);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}