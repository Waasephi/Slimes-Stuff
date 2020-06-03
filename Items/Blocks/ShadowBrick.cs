using OurStuffAddon.Tiles.Shadow;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Blocks
{
	public class ShadowBrick : ModItem
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
			item.createTile = ModContent.TileType<ShadowBrickTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.Anvils);
			recipe.AddIngredient(mod, "ShadowCrystal", 1);
			recipe.AddIngredient(ItemID.StoneBlock, 50);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}