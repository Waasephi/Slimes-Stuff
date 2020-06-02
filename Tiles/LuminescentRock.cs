
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
            Main.tileMerge[1][ModContent.TileType<Tiles.LuminescentRock>()] = true;
            drop = mod.ItemType("LuminescentRock");
            soundType = 21;
            dustType = 1;
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }



        public override bool CanExplode(int i, int j)
        {
            return true;
        }

       /* public override void RandomUpdate(int i, int j)
        {
            int randm = Main.rand.Next(18);
            if (Main.rand.Next(8) == 0)
            {
                bool spawned = false;
                spawned = SeafoamCrystalSpawn(i, j);
                if (!spawned)
                    spawned = SpawnRocks(i, j);
            }
            if (randm < 9)
            {
                if (CheckTile(i, j + 1))
                {
                    Terraria.WorldGen.PlaceTile(i, j + 1, mod.TileType("LLVine")(), true);
                }
                else if (Main.tile[i, j + 1].type == mod.TileType("LLVine")())
                {
                    for (int k = 1; k < 12; k++)
                    {
                        if (Main.tile[i, j + k].type != mod.TileType("LLVine")())
                        {
                            if (Main.tile[i, j + k].type == 0)
                                Terraria.WorldGen.PlaceTile(i, j + k, mod.TileType("LLVine")(), true);
                            break;
                        }
                    }
                }
            } 
        }
        public override void KillTile(int i, int j, ref bool fail, ref bool effectOnly, ref bool noItem)
        {
            if (j < Main.maxTilesY - 4)
            {
                if (Main.tile[i, j + 1].type == mod.TileType("LLVine")())
                    Terraria.WorldGen.KillTile(i, j + 1);
            }
        } 
        private bool CheckTile(int i, int j)
        {
            if (Main.tile[i, j].type != 0)
                return false;
            return true;
        }
        private bool SpawnRocks(int i, int j)
        {
            if (Main.tile[i, j - 1].type == 0 && Main.rand.Next(4) == 0)
            {
                WorldGen.PlaceTile(i, j - 1, mod.TileType("LLVine")(), true);
                return true;
            } 
            else if (Main.tile[i, j - 1].type == 0 && Main.tile[i, j - 2].type == 0 && Main.rand.Next(3) == 0)
            {
                WorldGen.PlaceTile(i, j - 1, mod.TileType("LLStalagmites")(), true);
                return true;
            }
            else if (Main.tile[i, j + 1].type == 0 && Main.tile[i, j + 2].type == 0 && Main.rand.Next(2) == 0)
            {
                WorldGen.PlaceTile(i, j + 1, mod.TileType("LLStalagtites")(), true);
                return true;
            }
            return false;
        } 

        private bool SeafoamCrystalSpawn(int i, int j)
        {
            if (Main.tile[i, j - 1].type == 0 && Main.tile[i, j].active())
            {
                if (Main.rand.Next(4) == 0)
                {
                    WorldGen.PlaceTile(i, j - 1, mod.TileType("SeafoamCrystal")(), true);
                    return true;
                }
            }
            return false;
        }*/
    }
}