using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Walls.Plague
{
	public class PlagueWoodFence : ModWall
	{
		public override void SetDefaults()
		{
			Main.wallHouse[Type] = true;
			 
			//drop = ModContent.ItemType<PlagueWoodFence>(); //TODO find out theres not item for this
			AddMapEntry(new Color(125, 0, 180));
		}

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0f;
			g = 0f;
			b = 0f;
		}
	}
}