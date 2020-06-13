using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.VanillaRecipes
{
	public class MAS : ModItem
	{
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AnkhShield);
			recipe.AddIngredient(175, 50);
			recipe.AddIngredient(ItemID.ObsidianRose);
			recipe.AddIngredient(1322);
			recipe.AddTile(114);
			recipe.SetResult(mod, "MoltenAnkhShield");
			recipe.AddRecipe();
		}
	}
}