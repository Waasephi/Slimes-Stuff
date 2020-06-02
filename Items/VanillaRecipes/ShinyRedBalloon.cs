using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.VanillaRecipes
{
	public class ShinyRedBalloon : ModItem
	{
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WhiteString);
			recipe.AddIngredient(ItemID.Silk, 20);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(ItemID.ShinyRedBalloon);
			recipe.AddRecipe();
		}
	}
}