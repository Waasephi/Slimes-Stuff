
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace OurStuffAddon.Tiles
{
    public class PhoenixStone : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileLighted[Type] = false;
            Main.tileBlockLight[Type] = true;
            AddMapEntry(new Color(240, 150, 150));
            mineResist = 1f;
            minPick = 150;
            Main.tileMerge[1][ModContent.TileType<Tiles.PhoenixStone>()] = true;
            Main.tileMerge[ModContent.TileType<Tiles.PhoenixStone>()][ModContent.TileType<Tiles.LuminescentRock>()] = true;
            Main.tileMerge[ModContent.TileType<Tiles.PhoenixStone>()][ModContent.TileType<Tiles.AncientStone>()] = true;
            drop = mod.ItemType("PhoenixStone");
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