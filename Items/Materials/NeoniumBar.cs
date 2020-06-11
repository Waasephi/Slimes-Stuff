using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Materials
{
	public class NeoniumBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Neonium Bar");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;                 //this is where you set the max stack of item
			item.consumable = false;           //this make that the item is consumable when used
			item.width = 80;
			item.height = 112;
			item.value = 100;
			item.rare = ItemRarityID.Lime;
			item.expert = false;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "NeoniumOre", 4);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}