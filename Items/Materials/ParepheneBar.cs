using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Items.Materials
{
	public class ParepheneBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Parephene Bar");
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
			recipe.AddIngredient(mod, "ParepheneOre", 6);
			recipe.AddTile(TileID.AdamantiteForge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}