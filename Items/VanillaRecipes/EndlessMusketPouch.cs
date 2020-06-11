using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.VanillaRecipes
{
	public class EndlessMusketPouch : ModItem
	{
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MusketBall, 3996);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.EndlessMusketPouch);
			recipe.AddRecipe();
		}
	}
}