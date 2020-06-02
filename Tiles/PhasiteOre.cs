using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Tiles
{
	public class PhasiteOre : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileLighted[Type] = false;
			Main.tileBlockLight[Type] = true;
			Main.tileSpelunker[Type] = true;
			AddMapEntry(new Color(200, 0, 200));
			mineResist = 1f;
			minPick = 80;
			drop = mod.ItemType("PhasiteOre");
			soundType = SoundID.Tink;
			dustType = 1;
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Phasite Ore");
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