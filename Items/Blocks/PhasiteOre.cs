using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Items.Blocks
{
	public class PhasiteOre : ModItem
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
			item.createTile = mod.TileType("PhasiteOre");
		}
	}
}