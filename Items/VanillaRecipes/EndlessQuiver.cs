using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.VanillaRecipes
{
	public class EndlessQuiver : ModItem
	{
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WoodenArrow, 3996);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.EndlessQuiver);
			recipe.AddRecipe();
		}
	}
}