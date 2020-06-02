
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

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
            Main.tileMergeDirt[Type] = true;
            mineResist = 1f;
            minPick = 100;
            drop = mod.ItemType("NeoniumOre");
            soundType = 21;
            dustType = 1;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Neonium Ore");
            AddMapEntry(new Color(0, 255, 0), name);
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