using Terraria.ModLoader;

namespace OurStuffAddon.Items.Blocks
{
	public class PhoenixWoodWall : ModItem
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
			item.createWall = mod.WallType("PhoenixWoodWall");
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<PhoenixWood>());
			recipe.AddTile(18);
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
		}
	}
}