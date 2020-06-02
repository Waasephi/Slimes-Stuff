using OurStuffAddon.Dusts;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

namespace OurStuffAddon.Tiles.Trees
{
	public class RebornPalm : ModPalmTree
	{
		public override Texture2D GetTexture() => ModContent.GetTexture("OurStuffAddon/Tiles/Trees/RebornPalm");
		
		public override Texture2D GetTopTextures() => ModContent.GetTexture("OurStuffAddon/Tiles/Trees/RebornPalm_Tops");

		public override int DropWood() {
			return ItemType<Items.Blocks.PhoenixWood>();
			}
	}
}