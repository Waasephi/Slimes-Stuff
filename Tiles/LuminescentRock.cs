
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace OurStuffAddon.Tiles
{
    public class LuminescentRock : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileLighted[Type] = true;
            Main.tileBlockLight[Type] = true;
            AddMapEntry(new Color(0, 200, 150));
            mineResist = 1f;
            minPick = 20;
            drop = mod.ItemType("LuminescentRock");
            soundType = 21;
            dustType = 1;
            //soundStyle = 1;
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0;
            g = 0.3f;
            b = 0.2f;
        }
        
        public override bool CanExplode(int i, int j)
        {
            return true;
        }

    }
}