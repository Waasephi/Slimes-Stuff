
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace OurStuffAddon.Tiles
{
    public class ShadowCrystalOre : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileLighted[Type] = false;
            Main.tileBlockLight[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileValue[Type] = 411;
            Main.tileMergeDirt[Type] = true;
            mineResist = 1f;
            minPick = 20;
            drop = mod.ItemType("ShadowCrystal");
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Shadow Crystal");
            AddMapEntry(new Color(0, 0, 0), name);
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

    }
}