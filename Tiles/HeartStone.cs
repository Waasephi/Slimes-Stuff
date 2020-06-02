
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace OurStuffAddon.Tiles
{
    public class HeartStone : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileLighted[Type] = false;
            Main.tileBlockLight[Type] = true;
            Main.tileSpelunker[Type] = true;

            mineResist = 1f;
            minPick = 50;
            drop = mod.ItemType("HeartStone");
            Main.tileMerge[ModContent.TileType<Tiles.HeartStone>()][2] = true;
            soundType = 21;
            dustType = 12;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("HeartStone");
            AddMapEntry(new Color(250, 100, 100), name);
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