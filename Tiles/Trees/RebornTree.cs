using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace OurStuffAddon.Tiles.Trees
{
	public class RebornTree : ModTree
	{
		private Mod mod => ModLoader.GetMod("OurStuffAddon");


		public override int DropWood() {
			return ItemType<Items.Blocks.PhoenixWood>();
		}

		public override Texture2D GetTexture() {
			return mod.GetTexture("Tiles/Trees/RebornTree");
		}

		public override Texture2D GetTopTextures(int i, int j, ref int frame, ref int frameWidth, ref int frameHeight, ref int xOffsetLeft, ref int yOffset) {
			return mod.GetTexture("Tiles/Trees/RebornTree_Tops");
		}

		public override Texture2D GetBranchTextures(int i, int j, int trunkOffset, ref int frame) {
			return mod.GetTexture("Tiles/Trees/RebornTree_Branches");
		}
	}
} 