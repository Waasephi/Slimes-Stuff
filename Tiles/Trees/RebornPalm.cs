using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace OurStuffAddon.Tiles.Trees
{
	public class RebornPalm : ModPalmTree
	{
		public override Texture2D GetTexture() => ModContent.GetTexture("OurStuffAddon/Tiles/Trees/RebornPalm");

		public override Texture2D GetTopTextures() => ModContent.GetTexture("OurStuffAddon/Tiles/Trees/RebornPalm_Tops");

		public override int DropWood()
		{
			return ItemType<Items.Blocks.PhoenixWood>();
		}
	}
}