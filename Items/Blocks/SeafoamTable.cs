using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Blocks
{
	public class SeafoamTable : ModItem
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
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.value = 0;
			item.createTile = ModContent.TileType<SeafoamTable>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.Anvils);
			recipe.AddIngredient(mod, "SeafoamBrick", 8);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}