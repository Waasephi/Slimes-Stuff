using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Tiles
{
	public class AncientPillar : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileLighted[Type] = false;
			Main.tileBlockLight[Type] = true;
			AddMapEntry(new Color(250, 230, 140));
			mineResist = 1f;
			minPick = 20;
			drop = mod.ItemType("AncientPillar");
			soundType = SoundID.Tink;
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
	}
}