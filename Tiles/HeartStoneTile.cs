using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using OurStuffAddon.Items.Blocks;

namespace OurStuffAddon.Tiles
{
	public class HeartStoneTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileLighted[Type] = false;
			Main.tileBlockLight[Type] = true;
			Main.tileSpelunker[Type] = true;
			AddMapEntry(new Color(250, 200, 200));
			mineResist = 1f;
			minPick = 50;
			drop = ModContent.ItemType<HeartStone>();
			soundType = SoundID.Tink;
			dustType = 12;
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Heart Stone");
			//soundStyle = 1;
		}

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}

		public override bool CanExplode(int i, int j)
		{
			return true;
		}
	}
}