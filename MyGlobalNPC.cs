using OurStuffAddon.Items.Accessories;
using OurStuffAddon.Items.Materials;
using OurStuffAddon.Items.Melee;
using OurStuffAddon.Items.Ranged;
using OurStuffAddon.Items.SpiritDamageClass;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon
{
	public class MyGlobalNPC : GlobalNPC
	{
		//TODO convert to NextBool
		public override void NPCLoot(NPC npc)
		{
			//The if (Main.rand.Next(x) == 0) determines how rare the drop is. To find the percent of a drop, divide 100 by your desired percent, minus the percent sign. Ex: A 2% chance would be 100% / 2%, or 50. This is what you put in place of x.

			switch (npc.type)
			{
				case NPCID.Mothron:
					switch (Main.rand.Next(5))
					{
						case 1:
							Item.NewItem(npc.getRect(), ModContent.ItemType<BrokenHeroBow>(), Main.rand.Next(1, 1));
							break;

						case 2:
							Item.NewItem(npc.getRect(), ModContent.ItemType<BrokenHeroBlaster>(), Main.rand.Next(1, 1));
							break;

						case 3:
							Item.NewItem(npc.getRect(), ModContent.ItemType<BrokenHeroDagger>(), Main.rand.Next(1, 1));
							break;
					}

					break;

				case NPCID.IceTortoise:
					if (Main.rand.Next(100) == 0) //1% chance
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<FrostStone>());
					}

					break;

				case NPCID.DarkCaster:
					if (Main.rand.Next(100) == 0) //1% chance
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<AncientBlaster>());
					}

					break;

				case NPCID.Vulture:
					if (Main.rand.Next(2) == 0) //50% chance
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<SandFeather>());
					}
					break;

				case NPCID.KingSlime:
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<CrownJewel>());
					break;

				case NPCID.EyeofCthulhu:
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<TheEye>());
					break;

				case NPCID.LunarTowerSolar:
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<LuminaFragment>(), Main.rand.Next(15, 20));
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<CosmicFragment>(), Main.rand.Next(15, 20));
					break;

				case NPCID.LunarTowerStardust:
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<LuminaFragment>(), Main.rand.Next(15, 20));
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<CosmicFragment>(), Main.rand.Next(15, 20));
					break;

				case NPCID.LunarTowerNebula:
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<LuminaFragment>(), Main.rand.Next(15, 20));
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<CosmicFragment>(), Main.rand.Next(15, 20));
					break;

				case NPCID.LunarTowerVortex:
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<LuminaFragment>(), Main.rand.Next(15, 20));
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<CosmicFragment>(), Main.rand.Next(15, 20));
					break;

				case NPCID.Demon:
					if (Main.rand.Next(100) == 0) //1% chance
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ReaperScythe>());
					}

					break;

				case NPCID.VoodooDemon:
					if (Main.rand.Next(50) == 0) //2% chance
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ReaperScythe>());

					break;

				case NPCID.WallofFlesh:
					switch (Main.rand.Next(3))
					{
						case 1:
							Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ThrowerEmblem>());
							break;

						case 2:
							Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<SpiricistEmblem>());
							break;
					}

					break;
			}

			if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneUnderworldHeight && Main.rand.Next(800) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<LavaShard>());
			}
			if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneCrimson && Main.rand.Next(800) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<TaintedCore>());
			}
			if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneCorrupt && Main.rand.Next(800) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<CursedCore>());
			}
			if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneBeach && Main.rand.Next(800) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<PsychicSand>());
			}
			if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneRain && Main.rand.Next(800) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<RainEssence>());
			}
			if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneSkyHeight && Main.rand.Next(3) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<SkyEssence>());
			}
			if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneJungle && Main.rand.Next(800) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<LivingMush>());
			}
			if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneSnow && Main.rand.Next(800) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<IceChip>());
			}
			if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneRockLayerHeight && Main.rand.Next(800) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<AncientCore>());
			}
			if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneHoly && Main.rand.Next(800) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<CrystalCore>());
			}
			if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneDungeon && Main.rand.Next(800) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<Ectoheart>());
			}
			if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneDesert && Main.rand.Next(800) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<BottledDune>());
			}
			if (npc.type == NPCID.Lihzahrd)
			{
				if (Main.rand.Next(2) == 0) //50% chance
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<SolarPebble>(), Main.rand.Next(1, 2));
				}
			}
			if (npc.type == NPCID.LihzahrdCrawler)
			{
				if (Main.rand.Next(2) == 0) //50% chance
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<SolarPebble>(), Main.rand.Next(1, 2));
				}
			}
			if (npc.type == NPCID.FlyingSnake)
			{
				if (Main.rand.Next(3) == 0) //33% chance
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<SolarPebble>(), Main.rand.Next(2, 3));
				}
			}
			if (npc.type == NPCID.SandElemental)
			{
				if (Main.rand.Next(3) == 0) //33% chance
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<SunBlade>());
				}
			}
		}
	}
}