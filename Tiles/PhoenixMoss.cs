using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Tiles
{
	public class PhoenixMoss : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileLighted[Type] = false;
			Main.tileBlockLight[Type] = true;
			AddMapEntry(new Color(240, 120, 120));
			mineResist = 1f;
			minPick = 100;
			Main.tileMerge[1][ModContent.TileType<Tiles.PhoenixMoss>()] = true;
			Main.tileMerge[ModContent.TileType<Tiles.PhoenixStone>()][ModContent.TileType<Tiles.PhoenixMoss>()] = true;
			Main.tileMerge[ModContent.TileType<Tiles.PhoenixStone>()][1] = true;
			Main.tileMerge[ModContent.TileType<Tiles.PhoenixMoss>()][ModContent.TileType<Tiles.AncientStone>()] = true;
			Main.tileMerge[ModContent.TileType<Tiles.PhoenixMoss>()][ModContent.TileType<Tiles.PhoenixStone>()] = true;
			Main.tileMerge[ModContent.TileType<Tiles.PhoenixMoss>()][ModContent.TileType<Tiles.LuminescentRock>()] = true;
			drop = mod.ItemType("PhoenixMoss");
			soundType = 21;
			dustType = 1;
			//soundStyle = 1;
		}

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}

		/*public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.2f;
            g = 0.1f;
            b = 0.2f;
        }

        public override bool CanExplode(int i, int j)
        {
            return false;
        }*/

		public override int SaplingGrowthType(ref int style)
		{
			style = 0;
			return ModContent.TileType<RebornSapling>();
		}
	}
}