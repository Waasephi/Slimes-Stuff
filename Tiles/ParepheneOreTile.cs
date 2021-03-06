using Microsoft.Xna.Framework;
using OurStuffAddon.Items.Blocks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Tiles
{
	public class ParepheneOreTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileLighted[Type] = false;
			Main.tileBlockLight[Type] = true;
			Main.tileSpelunker[Type] = true;
			AddMapEntry(new Color(0, 200, 0));
			mineResist = 1f;
			minPick = 120;
			drop = ModContent.ItemType<ParepheneOre>();
			soundType = SoundID.Tink;
			dustType = 1;
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Parephene Ore");
			//soundStyle = 1;
		}

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}

		public override bool CanExplode(int i, int j)
		{
			return false;
		}
	}
}