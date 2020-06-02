using Terraria.ModLoader;

namespace OurStuffAddon.Items.Blocks
{
	public class ShadowGemsparkBlock : ModItem
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
			item.createTile = mod.TileType("ShadowGemsparkBlock");
		}

		/* public override void AddRecipes()
		 {
			 ModRecipe recipe = new ModRecipe(mod);
			 recipe.AddTile(TileID.Anvils);
			 recipe.AddIngredient(mod, "ShadowCrystal", 1);
			 recipe.AddIngredient(170, 20);
			 recipe.SetResult(this, 20);
			 recipe.AddRecipe();
		 }*/
	}
}