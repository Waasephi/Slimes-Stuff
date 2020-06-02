
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace OurStuffAddon.Tiles
{
    public class SeafoamStone : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileLighted[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileMerge[ModContent.TileType<Tiles.SeafoamStone>()][ModContent.TileType<Tiles.LuminescentRock>()] = true;
            mineResist = 1f;
            minPick = 20;
            drop = mod.ItemType("SeafoamCrystal");
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Seafoam Stone");
            AddMapEntry(new Color(100, 200, 200), name);
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
            g = 0.4f;
            b = 0.3f;
        }
        
        public override bool CanExplode(int i, int j)
        {
            return true;
        }

    }
}