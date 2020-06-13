/*using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Structures
{
    public class LuminescentHouse2
    {
        private static readonly int[,] _structureArray = new int[,]
        {
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,9,7,9,9,9,9,9,9,9,9,9,9,9,9,7,9,9,9,9,9,4,4,4,3,1},
            {1,9,7,9,9,9,9,9,9,9,9,9,9,9,9,7,9,9,9,9,9,9,3,4,4,1},
            {1,9,7,9,6,9,9,9,9,9,9,9,9,9,9,7,3,9,9,9,9,9,9,3,4,1},
            {1,9,7,9,9,9,9,9,9,9,9,9,9,9,9,3,4,3,9,9,9,9,9,3,4,1},
            {1,9,7,6,9,9,6,9,9,9,9,9,9,9,4,3,4,4,3,9,2,9,4,4,3,1},
            {1,1,1,1,1,1,1,1,1,5,5,5,5,5,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,4,4,4,9,9,9,9,9,9,9,9,9,9,9,7,9,1,0,0,0,0,0,0,0,0},
            {1,3,4,9,9,9,9,9,9,9,9,9,9,9,9,7,9,1,0,0,0,0,0,0,0,0},
            {1,4,7,9,9,9,9,9,9,9,9,9,9,9,9,7,9,9,0,0,0,0,0,0,0,0},
            {1,4,4,9,9,9,9,9,9,9,9,9,9,9,9,7,9,9,0,0,0,0,0,0,0,0},
            {1,3,3,4,4,9,6,9,9,9,8,9,9,9,9,7,9,9,0,0,0,0,0,0,0,0},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,5,5,5,1,1,0,0,0,0,0,0,0,0},
        };

        public static void StructureGen(int xPosO, int yPosO, bool mirrored)
        {
            //Obsidium Heart
            /**
             * 0 = Do Nothing
             * 1 = Obsidium Brick
             * 2 = Obsidium Chest
             * 3 = Lycoris
             * 4 = Radiata
             * 5 = Platform
             * 6 = wooden crate
             * 7 = lavafall
             * 8 = ?
             * 9 = Kill tile
             *

            for (int i = 0; i < _structureArray.GetLength(1); i++)
            {
                for (int j = 0; j < _structureArray.GetLength(0); j++)
                {
                    if (mirrored)
                    {
                        if (TileCheckSafe((int)(xPosO + _structureArray.GetLength(1) - i), (int)(yPosO + j)))
                        {
                            if (_structureArray[j, i] == 1)
                            {
                                WorldGen.KillTile(xPosO + _structureArray.GetLength(1) - i, yPosO + j);
                                WorldGen.PlaceTile(xPosO + _structureArray.GetLength(1) - i, yPosO + j, mod.TileType("LuminescentRock")(), true, true);
                            }
                            if (_structureArray[j, i] == 2)
                            {
                                LaugicalityWorld.PlaceObsidiumChest(xPosO + _structureArray.GetLength(1) - i, yPosO + j, (ushort)mod.TileType("LuminescentRock")());
                            }
                            if (_structureArray[j, i] == 3)
                            {
                                WorldGen.KillTile(xPosO + _structureArray.GetLength(1) - i, yPosO + j);
                                WorldGen.PlaceTile(xPosO + _structureArray.GetLength(1) - i, yPosO + j, mod.TileType("SeafoamStone")(), true, true);
                            }
                            if (_structureArray[j, i] == 4)
                            {
                                WorldGen.KillTile(xPosO + _structureArray.GetLength(1) - i, yPosO + j);
                                WorldGen.PlaceTile(xPosO + _structureArray.GetLength(1) - i, yPosO + j, mod.TileType("SeafoamStone")(), true, true);
                            }
                            if (_structureArray[j, i] == 5)
                            {
                                WorldGen.KillTile(xPosO + _structureArray.GetLength(1) - i, yPosO + j);
                                WorldGen.PlaceTile(xPosO + _structureArray.GetLength(1) - i, yPosO + j, mod.TileType("SeafoamPlatform")(), true, true, -1, 13);
                            }
                            if (_structureArray[j, i] == 6)
                            {
                                WorldGen.KillTile(xPosO + _structureArray.GetLength(1) - i, yPosO + j);
                                WorldGen.KillTile(xPosO + _structureArray.GetLength(1) - i + 1, yPosO + j);
                                WorldGen.KillTile(xPosO + _structureArray.GetLength(1) - i, yPosO + j - 1);
                                WorldGen.KillTile(xPosO + _structureArray.GetLength(1) - i + 1, yPosO + j - 1);
                                Terraria.WorldGen.PlaceObject(xPosO + _structureArray.GetLength(1) - i, yPosO + j, 376, true, 0, -1, -1);
                            }
                            if (_structureArray[j, i] == 7)
                            {
                                WorldGen.KillTile(xPosO + _structureArray.GetLength(1) - i, yPosO + j);
                                WorldGen.KillWall(xPosO + _structureArray.GetLength(1) - i, yPosO + j);
                                WorldGen.PlaceWall(xPosO + _structureArray.GetLength(1) - i, yPosO + j, 136, true); //Lavafall Wall
                            }
                            if (_structureArray[j, i] == 8)
                            {
                                WorldGen.KillTile(xPosO + _structureArray.GetLength(1) - i, yPosO + j);
                                WorldGen.KillTile(xPosO + _structureArray.GetLength(1) - i + 1, yPosO + j);
                                WorldGen.KillTile(xPosO + _structureArray.GetLength(1) - i, yPosO + j - 1);
                                WorldGen.KillTile(xPosO + _structureArray.GetLength(1) - i + 1, yPosO + j - 1);
                                Terraria.WorldGen.PlaceObject(xPosO + _structureArray.GetLength(1) - i, yPosO + j, 376, true, 0, -1, -1);
                            }
                            if (_structureArray[j, i] == 9)
                            {
                                Main.tile[xPosO + _structureArray.GetLength(1) - i, yPosO + j].liquid = 0;
                                WorldGen.KillTile(xPosO + _structureArray.GetLength(1) - i, yPosO + j);
                            }
                        }
                    }
                    else
                    {
                        if (TileCheckSafe((int)(xPosO + i), (int)(yPosO + j)))
                        {
                            if (_structureArray[j, i] == 1)
                            {
                                WorldGen.KillTile(xPosO + i, yPosO + j);
                                WorldGen.PlaceTile(xPosO + i, yPosO + j, mod.TileType("LuminescentRock")(), true, true);
                            }
                            if (_structureArray[j, i] == 2)
                            {
                                LaugicalityWorld.PlaceObsidiumChest(xPosO + i, yPosO + j, (ushort)mod.TileType("LuminescentRock")());
                            }
                            if (_structureArray[j, i] == 3)
                            {
                                WorldGen.KillTile(xPosO + i, yPosO + j);
                                WorldGen.PlaceTile(xPosO + i, yPosO + j, mod.TileType("SeafoamStone")(), true, true);
                            }
                            if (_structureArray[j, i] == 4)
                            {
                                WorldGen.KillTile(xPosO + i, yPosO + j);
                                WorldGen.PlaceTile(xPosO + i, yPosO + j, mod.TileType("SeafoamStone")(), true, true);
                            }
                            if (_structureArray[j, i] == 5)
                            {
                                WorldGen.KillTile(xPosO + i, yPosO + j);
                                WorldGen.PlaceTile(xPosO + i, yPosO + j, mod.TileType("SeafoamPlatform")(), true, true, -1, 13);
                            }
                            if (_structureArray[j, i] == 6)
                            {
                                WorldGen.KillTile(xPosO + i, yPosO + j);
                                WorldGen.KillTile(xPosO + i + 1, yPosO + j);
                                WorldGen.KillTile(xPosO + i, yPosO + j - 1);
                                WorldGen.KillTile(xPosO + i + 1, yPosO + j - 1);
                                Terraria.WorldGen.PlaceObject(xPosO + i, yPosO + j, 376, true, 0, -1, -1);
                            }
                            if (_structureArray[j, i] == 7)
                            {
                                WorldGen.KillTile(xPosO + i, yPosO + j);
                                WorldGen.KillWall(xPosO + i, yPosO + j);
                                WorldGen.PlaceWall(xPosO + i, yPosO + j, 136, true); //Lavafall Wall
                            }
                            if (_structureArray[j, i] == 8)
                            {
                                WorldGen.KillTile(xPosO + i, yPosO + j);
                                WorldGen.KillTile(xPosO + i + 1, yPosO + j);
                                WorldGen.KillTile(xPosO + i, yPosO + j - 1);
                                WorldGen.KillTile(xPosO + i + 1, yPosO + j - 1);
                                Terraria.WorldGen.PlaceObject(xPosO + i, yPosO + j, 376, true, 0, -1, -1);
                            }
                            if (_structureArray[j, i] == 9)
                            {
                                Main.tile[xPosO + i, yPosO + j].liquid = 0;
                                WorldGen.KillTile(xPosO + i, yPosO + j);
                            }
                        }
                    }
                }
            }
        }
    }
}*/