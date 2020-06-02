using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Materials
{
	public class DarkSteel : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dark Steel");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;                 //this is where you set the max stack of item
			item.consumable = false;           //this make that the item is consumable when used
			item.width = 80;
			item.height = 112;
			item.value = 100;
			item.rare = ItemRarityID.Purple;
			item.expert = false;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 2);
			recipe.AddIngredient(ItemID.Bone, 2);
			recipe.AddIngredient(ItemID.JungleSpores, 2);
			recipe.AddRecipeGroup("OurStuffAddon:EvilBar", 2);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}