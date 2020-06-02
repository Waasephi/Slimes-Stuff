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
			recipe.AddTile(18);
			recipe.SetResult(ItemID.EndlessQuiver);
			recipe.AddRecipe();
		}
	}
}