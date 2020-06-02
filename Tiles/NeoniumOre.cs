using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Tiles
{
	public class NeoniumOre : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileLighted[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileSpelunker[Type] = true;
			AddMapEntry(new Color(0, 255, 0));
			mineResist = 1f;
			minPick = 101;
			drop = mod.ItemType("NeoniumOre");
			soundType = SoundID.Tink;
			dustType = 1;
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Neonium Ore");
			//soundStyle = 1;
		}

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0;
			g = 1f;
			b = 0f;
		}

		public override bool CanExplode(int i, int j)
		{
			return false;
		}
	}
}