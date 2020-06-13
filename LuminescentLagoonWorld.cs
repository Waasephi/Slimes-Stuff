/*using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon
{
        partial class LuminescentLagoonWorld
        {
            private void GenerateLuminecent(int xO, int yO)
            {
                CreateLuminescentRock(xO, yO);

                CreateLuminescentCaverns(xO, yO);

                GenerateLuminescentFeatures(xO, yO);
            }

            private void CreateLuminescentRock(int xO, int yO)
            {
                for (int i = (int)(-225 * sizeMult); i <= (int)(225 * sizeMult); i++)
                {
                    for (int j = (int)(-275 * sizeMult); j <= (int)(275 * sizeMult); j++)
                    {
                        CreateLuminescentTileCheck(xO, yO, i, j);
                    }
                }
            }

            private void CreateLuminescentCaverns(int xO, int yO)
            {
                for (int i = (int)(-250 * sizeMult); i <= (int)(250 * sizeMult); i++)
                {
                    for (int j = (int)(-325 * sizeMult); j <= (int)(325 * sizeMult); j++)
                    {
                        if (TileCheckSafe(xO + i, yO + j))
                        {
                            if (Main.tile[xO + i, yO + j].type == (ushort)249)
                            {
                                WorldGen.KillTile(xO + i, yO + j);
                            }
                        }
                    }
                }
            }

            private void CreateLuminescentTileCheck(int xO, int yO, int i, int j)
            {
                if (TileCheckSafe(xO + i, yO + j))
                {
                    if (Main.tile[xO + i, yO + j].wall != WallID.LihzahrdBrick && Main.tile[xO + i, yO + j].type != TileID.LihzahrdBrick)
                    {
                        if (j < -(int)(150 * sizeMult))
                        {
                            GenerateCavernTop(xO, yO, i, j);
                        }
                        else if (j < 0)
                        {
                            GenerateCavernTopMid(xO, yO, i, j);
                        }
                        else if (j < (int)(100 * sizeMult))
                        {
                            GenerateCavernMid(xO, yO, i, j);
                        }
                        else if (yO + j < Main.maxTilesY - 200)
                        {
                            GenerateCavernBottom(xO, yO, i, j);
                        }
                    }
                }
            }

        private void GenerateCavernTop(int xO, int yO, int i, int j)
        {
            int sign = 1;
            if (i != 0)
                sign = (int)(Math.Abs(i) / i);
            if (Distance(xO + sign * 100 * sizeMult, yO - 150 * sizeMult, xO + i, yO + j) < 100 * sizeMult)
            {
                PlaceTile(xO + i, yO + j, mod.TileType("LuminescentRock")(), mod.WallType("LuminescentRockWall"));
            }
            else if (Distance(xO + sign * 100 * sizeMult, yO - (int)(150 * sizeMult), xO + i, yO + j) < 100 * sizeMult + 6)
            {
                if (Main.rand.Next(6) < 100 * sizeMult + 6 - Distance(xO + sign * 100 * sizeMult, yO - 150 * sizeMult, xO + i, yO + j))
                {
                    PlaceTile(xO + i, yO + j, mod.TileType("LuminescentRock")());
                }
            }
        }

        private void GenerateCavernTopMid(int xO, int yO, int i, int j)
        {
            if (Distance(xO + i, yO + j, xO, yO) < (int)(150 * sizeMult - (int)(j * 2 / 3)))
            {
                PlaceTile(xO + i, yO + j, mod.TileType("LuminescentRock")(), mod.WallType("LuminescentRockWall"));
            }
            else if (Distance(xO + i, yO + j, xO, yO) < (int)(150 * sizeMult - (int)(j * 2 / 3)) + 6)
            {
                if (Main.rand.Next(6) < -Distance(xO + i, yO + j, xO, yO) + 6 + (int)(150 * sizeMult - (int)(j * 2 / 3)))
                {
                    PlaceTile(xO + i, yO + j, mod.TileType("LuminescentRock")());
                }
            }
        }

        private void GenerateCavernMid(int xO, int yO, int i, int j)
        {
            if (Distance(xO + i, yO + j, xO, yO) < (int)(150 * sizeMult - .47 * j))
            {
                PlaceTile(xO + i, yO + j, mod.TileType("LuminescentRock")(), mod.WallType("LuminescentRockWall"));
            }
            else if (Distance(xO + i, yO + j, xO, yO) < (int)(150 * sizeMult - .47 * j) + 6)
            {
                if (Main.rand.Next(6) < -Distance(xO + i, yO + j, xO, yO) + 6 + (int)(150 * sizeMult - .47 * j))
                {
                    PlaceTile(xO + i, yO + j, mod.TileType("LuminescentRock")());
                }
            }
        }

        private void GenerateCavernBottom(int xO, int yO, int i, int j)
        {
            int radius = (Main.maxTilesY - 200) - (yO + (int)(100 * sizeMult));
            if (i < 0 && i > -radius)
            {
                if (Distance(xO + i, yO + j, xO - (int)(25 * sizeMult) - radius, yO + (int)(100 * sizeMult)) > radius)
                {
                    PlaceTile(xO + i, yO + j, mod.TileType("LuminescentRock")(), mod.WallType("LuminescentRockWall"));
                }
                else if (Distance(xO + i, yO + j, xO - (int)(25 * sizeMult) - radius, yO + (int)(100 * sizeMult)) < radius + 6)
                {
                    if (Main.rand.Next(6) < Distance(xO + i, yO + j, xO - (int)(25 * sizeMult) - radius, yO + (int)(100 * sizeMult)) - 6 - radius)
                    {
                        PlaceTile(xO + i, yO + j, mod.TileType("LuminescentRock")());
                    }
                }
            }
            else if (i >= 0 && i < radius + 1)
            {
                if (Distance(xO + i, yO + j, xO + (int)(25 * sizeMult) + radius, yO + (int)(100 * sizeMult)) > radius)
                {
                    PlaceTile(xO + i, yO + j, mod.TileType("LuminescentRock")(), mod.WallType("LuminescentRockWall"));
                }
                else if (Distance(xO + i, yO + j, xO + (int)(25 * sizeMult) + radius, yO + (int)(100 * sizeMult)) < radius + 6)
                {
                    if (Main.rand.Next(6) < Distance(xO + i, yO + j, xO + (int)(25 * sizeMult) + radius, yO + (int)(100 * sizeMult)) - 6 - radius)
                    {
                        PlaceTile(xO + i, yO + j, mod.TileType("LuminescentRock")());
                    }
                }
            }
        }

        private void GenerateLuminescentFeatures(int xO, int yO)
        {
            GenerateFeature(xO, yO, 25, (ushort)mod.TileType("SeafoamStone")(), 2, 6, 180 * sizeMult);
            GenerateFeature(xO, yO, 75, (ushort)mod.TileType("SeafoamStone")(), 3, 5, 180 * sizeMult);
        }

        private void GenerateCave(int xO, int yO, int numSteps, ushort tileType, int minSize, int maxSize, int length)
        {
            for (int k = 0; k < numSteps * sizeMult; k++)
            {
                int x = xO + Main.rand.Next(-200 * sizeMult, 200 * sizeMult);
                int y = yO + Main.rand.Next(-250 * sizeMult, 250 * sizeMult);
                if (Main.tile[x, y].type == (ushort)mod.TileType("LuminescentRock")() || (Main.tile[x, y].active() == false && Main.tile[x, y].wall == mod.WallType("LuminescentRockWall")) || Main.tile[x, y].type == (ushort)mod.TileType("SeafoamStone")())
                    WorldGen.TileRunner(x, y, Main.rand.Next(minSize, maxSize), length, tileType, false, 0f, 0f, false, true);
            }
        }

        private void GenerateFeature(int xO, int yO, int numSteps, ushort tileType, int minSize, int maxSize, int length)
        {
            for (int k = 0; k < numSteps * sizeMult; k++)
            {
                int x = xO + Main.rand.Next(-225 * sizeMult, 225 * sizeMult);
                int y = yO + Main.rand.Next(-275 * sizeMult, 275 * sizeMult);
                if (Main.tile[x, y].type == (ushort)mod.TileType("LuminescentRock")() || (Main.tile[x, y].active() == false && Main.tile[x, y].wall == mod.WallType("LuminescentRockWall")) || Main.tile[x, y].type == (ushort)ModContent.TileType<Tiles.Radiata>())
                    WorldGen.TileRunner(x, y, Main.rand.Next(minSize, maxSize), length, tileType, false, 0f, 0f, false, true);
            }
        }

        private void GenerateLuminescentStructures(int xO, int yO)
        {
            DecorationStructures(xO, yO);

            LootStructures(xO, yO);

            HeartWorld.HeartGen(xO - 60, yO - 90);
        }

        private void DecorationStructures(int xO, int yO)
        {
            int s = Main.rand.Next(8);
            int structX = xO - 225 * sizeMult + Main.rand.Next(225 * sizeMult * 2);
            int structY = yO - 275 * sizeMult + Main.rand.Next(275 * sizeMult / 2);

            for (int q = 0; q < 12 * sizeMult; q++)
            {
                s = GenerateDecorationStructure(s, structX, structY);
                Point16 newStructurePosition = new Point16(structX, structY);
                newStructurePosition = AlterStructureLocation(xO, yO, structX, structY);
                structX = newStructurePosition.X;
                structY = newStructurePosition.Y;
            }
        }

        private int GenerateDecorationStructure(int s, int structX, int structY)
        {
            if (TileCheckSafe(structX, structY))
            {
                if (Main.tile[structX, structY].wall == (ushort)mod.WallType("LuminescentRockWall"))
                {
                    bool mirrored = false;
                    if (Main.rand.Next(2) == 0)
                        mirrored = true;

                    PickDecorationStructure(s, structX, structY, mirrored);

                    s++;
                    if (s >= 8)
                        s = 0;
                }
            }
            return s;
        }

        private Point16 AlterStructureLocation(int xO, int yO, int structX, int structY)
        {
            structX = Main.rand.Next(-250 * sizeMult, 250 * sizeMult) + xO;
            structY = Main.rand.Next(-275 * sizeMult, 275 * sizeMult) + yO;
            Point16 structurePosition = new Point16(structX, structY);
            return structurePosition;
        }

        private void LootStructures(int xO, int yO)
        {
            int structX = xO - 225 * sizeMult + Main.rand.Next(225 * sizeMult * 2);
            int structY = yO - 275 * sizeMult + Main.rand.Next(275 * sizeMult / 2);

            for (int q = 0; q < 10 * sizeMult; q++)
            {
                GenerateLootStructure(structX, structY);
                Point16 newStructurePosition = new Point16(structX, structY);
                newStructurePosition = AlterStructureLocation(xO, yO, structX, structY);
                structX = newStructurePosition.X;
                structY = newStructurePosition.Y;
            }
        }

        private void GenerateLootStructure(int structX, int structY)
        {
            if (TileCheckSafe(structX, structY))
            {
                if (Main.tile[structX, structY].wall == (ushort)mod.WallType("LuminescentRockWall"))
                {
                    LuminescentHouses.GenerateHouse(structX, structY);
                }
            }
        }

        public static void PlaceLuminescentChest(int x, int y, ushort floorType)
        {
            ClearSpaceForChest(x, y, floorType);
            int chestIndex = WorldGen.PlaceChest(x, y, (ushort)mod.TileType("LuminescentChest")(), false, 0);

            int specialItem = GetLuminescentLoot();
            LuminescentPosition++;
            int[] oreLoot = GetLuminescentOreLoot();
            int[] potionLoot = GetLuminescentPotionLoot();
            int[] money = GetLuminescentMoneyLoot();
            int[] miscLoot = GetLuminescentMiscLoot();

            int[] itemsToPlaceInChests = new int[] { specialItem, oreLoot[0], potionLoot[0], money[0], miscLoot[0] };
            int[] itemCounts = new int[] { 1, oreLoot[1], potionLoot[1], money[1], miscLoot[1] };

            FillChest(chestIndex, itemsToPlaceInChests, itemCounts);
        }

        private static int GetLuminescentLoot()
        {
            int[] luminescentLoot = new int[] { mod.TileType("SeafoamHeart")(), mod.TileType("CrystalizedParasite")(), mod.TileType("SeafoamHeart")(), mod.TileType("LuminescentStaff")(), mod.TileType("SeafoamBat")(), mod.TileType("SeafoamLongbow")(), };

            if (luminescentPosition < luminescentLoot.GetLength(0))
                return luminescentLoot[luminescentPosition];
            else
            {
                luminescentPosition = 0;
                return luminescentLoot[luminescentPosition];
            }
        }

        private static int[] GetLuminescentOreLoot()
        {
            int[] oreLoot = new int[] { ItemID.GoldBar, ItemID.PlatinumBar, ItemID.TungstenBar, ItemID.SilverBar, mod.TileType("TrenagonBar")() };
            int orePos = Main.rand.Next(oreLoot.GetLength(0));
            int oreCount = Main.rand.Next(6, 16);
            int[] ore = { 0, 0 };
            ore[0] = oreLoot[orePos];
            ore[1] = oreCount;
            return ore;
        }

        private static int[] GetLuminescentPotionLoot()
        {
            int[] potLoot = new int[] { mod.ItemType("LuminescentPotion")(), mod.ItemType("SpiritDamagePotion")(), mod.ItemType("SeafoamPotion")() };
            int potPos = Main.rand.Next(potLoot.GetLength(0));
            int potCount = Main.rand.Next(2, 3);
            int[] pot = { 0, 0 };
            pot[0] = potLoot[potPos];
            pot[1] = potCount;
            return pot;
        }

        private static int[] GetLuminescentMoneyLoot()
        {
            int monType = 0;
            int monCount = 0;
            if (Main.rand.Next(2) == 0)
            {
                monType = ItemID.GoldCoin;
                monCount = Main.rand.Next(1, 4);
            }
            else
            {
                monType = ItemID.SilverCoin;
                monCount = Main.rand.Next(60, 99);
            }
            int[] mon = { 0, 0 };
            mon[0] = monType;
            mon[1] = monCount;
            return mon;
        }

        private static int[] GetLuminescentMiscLoot()
        {
            int[] mscLoot = new int[] {
                mod.ItemType("SeafoamCrystal")(), mod.ItemType("SeafoamScale")(),
                mod.ItemType("SeafoamCrystal")(), mod.ItemType("SeafoamScale")(),
                mod.ItemType("SeafoamCrystal")(), mod.ItemType("SeafoamScale")(),
            };
            int mscPos = Main.rand.Next(mscLoot.GetLength(0));
            int mscCount = Main.rand.Next(2, 6);
            int[] msc = { 0, 0 };
            msc[0] = mscLoot[mscPos];
            msc[1] = mscCount;
            return msc;
        }

        public override void PostWorldGen()
        {
            DryTheLuminescent();
            GrowSeafoamCrystals();
        }

        private void DryTheLuminescent()
        {
            for (int i = 0; i < Main.maxTilesX - 2; i++)
            {
                for (int j = 0; j < Main.maxTilesY - 2; j++)
                {
                    if (TileCheckSafe(i, j))
                    {
                        if (Main.tile[i, j].liquid > 0 && Main.tile[i, j].lava() == false && (Main.tile[i, j].wall == (ushort)mod.WallType("LuminescentRockWall") || Main.tile[i, j].wall == WallID.Waterfall))
                        {
                            Main.tile[i, j].liquid = 0;
                        }
                    }
                }
            }
        }

        private void GrowSeafoamCrystals()
        {
            for (int i = 0; i < Main.maxTilesX - 2; i++)
            {
                for (int j = 0; j < Main.maxTilesY - 2; j++)
                {
                    if (TileCheckSafe(i, j) && TileCheckSafe(i, j + 1))
                    {
                        if (Main.tile[i, j].wall == (ushort)mod.WallType("LuminescentRockWall")() && Main.tile[i, j + 1].type == (ushort)mod.TileType("LuminescentRock")() && Main.tile[i, j].type == 0 && Main.tile[i, j].active() == false)
                        {
                            if (Main.rand.Next(8) == 0)
                            {
                                WorldGen.PlaceTile(i, j, mod.TileType("LuminescentRock")(), true);
                            }
                        }
                        else if (Main.tile[i, j].wall == (ushort)mod.WallType("LuminescentRockWall") && Main.tile[i, j].type == (ushort)mod.TileType("LuminescentRock")())
                        {
                            if (Main.rand.Next(3) == 0)
                            {
                                if (TileCheckSafe(i, j - 1) && TileCheckSafe(i, j + 1) && TileCheckSafe(i, j - 2) && TileCheckSafe(i, j + 2))
                                    SpawnRocks(i, j);
                            }
                        }
                    }
                }
            }
        }

        private bool SpawnRocks(int i, int j)
        {
            if (Main.tile[i, j - 1].type == 0 && Main.rand.Next(4) == 0)
            {
                WorldGen.PlaceTile(i, j - 1, mod.TileType("LLRocks")(), true);
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
    }
} */