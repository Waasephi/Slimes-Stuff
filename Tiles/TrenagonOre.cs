
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace OurStuffAddon.Tiles
{
    public class TrenagonOre : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileLighted[Type] = false;
            Main.tileBlockLight[Type] = true;
            Main.tileSpelunker[Type] = true;
            AddMapEntry(new Color(0, 200, 0));
            mineResist = 1f;
            minPick = 50;
            drop = mod.ItemType("TrenagonOre");
            soundType = 21;
            dustType = 1;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Trenagon Ore");
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