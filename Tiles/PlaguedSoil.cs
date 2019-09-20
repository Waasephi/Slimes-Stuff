using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Tiles
{
    public class PlaguedSoil : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileLighted[Type] = true;
            drop = mod.ItemType("PlaguedSoil");
            AddMapEntry(new Color(150, 0, 200));
            SetModTree(new PlagueTree());
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.1f;
            g = 0f;
            b = 0.1f;
        }


        public override int SaplingGrowthType(ref int style)
        {
            style = 0;
            return mod.TileType("PlagueSapling");
        }
    }
}