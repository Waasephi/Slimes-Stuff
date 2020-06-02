
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

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
            Main.tileMergeDirt[Type] = true;
            mineResist = 1f;
            minPick = 80;
            drop = mod.ItemType("PhasiteOre");
            soundType = 21;
            dustType = 1;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Phasite Ore");
            AddMapEntry(new Color(200, 0, 200), name);
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