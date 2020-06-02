using System;
using System.Collections.Generic;
using Terraria;
using Terraria.GameContent.Generation;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.World.Generation;

namespace OurStuffAddon
{
	public class OurStuffAddonWorld : ModWorld
	{
		public static bool downedCosmicSlime = false;
		public static bool downedLifeEnforcer = false;
		public static bool downedGiantSandSifter = false;
		public static bool downedNeoMothership = false;
		public static bool downedNeoParasite = false;
		public static bool downedAncientObserver = false;
		public static int LuminescentLagoon = 0;
		public static int Ruin = 0;
		public static bool heartStone = false;
		public static int sizeMult = (int)(Math.Round(Main.maxTilesX / 4200f)); //Small = 2; Medium = ~3; Large = 4;

		public override void Initialize()
		{
			sizeMult = (int)(Math.Floor(Main.maxTilesX / 4200f));
			downedCosmicSlime = false;
			downedLifeEnforcer = false;
			downedGiantSandSifter = false;
			downedNeoMothership = false;
			downedNeoParasite = false;
			downedAncientObserver = false;
			heartStone = false;
		}

		public override void Load(TagCompound tag)
		{
			IList<string> downed = tag.GetList<string>("downed");
			downedGiantSandSifter = downed.Contains("GiantSandSifter");
			downedCosmicSlime = downed.Contains("CosmicSlime");
			downedLifeEnforcer = downed.Contains("LifeEnforcer");
			downedNeoMothership = downed.Contains("NeoMothership");
			downedAncientObserver = downed.Contains("AncientObserver");
			heartStone = tag.GetBool("heartStone");
		}

		public override TagCompound Save()
		{
			List<string> downed = new List<string>();

			if (downedGiantSandSifter)
				downed.Add("GiantSandSifter");
			if (downedLifeEnforcer)
				downed.Add("LifeEnforcer");
			if (downedCosmicSlime)
				downed.Add("CosmicSlime");
			if (downedNeoParasite)
				downed.Add("NeoParasite");
			if (downedNeoMothership)
				downed.Add("NeoMothership");
			if (downedAncientObserver)
				downed.Add("AncientObserver");

			return new TagCompound {
				{"downed", downed},
				{"enforced", downedLifeEnforcer},
				{"heartStone", heartStone },
			};
		}

		public override void ResetNearbyTileEffects()
		{
			LuminescentLagoon = 0;
			Ruin = 0;
		}

		public override void TileCountsAvailable(int[] tileCounts)
		{
			LuminescentLagoon = tileCounts[mod.TileType("LuminescentRock")];       //this make the public static int customBiome counts as customtileblock
			Ruin = tileCounts[mod.TileType("AncientStone")] + tileCounts[mod.TileType("FadedStone")] + tileCounts[mod.TileType("BlueFadedStone")] + tileCounts[mod.TileType("RedFadedStone")] + tileCounts[mod.TileType("GreenFadedStone")];
		}

		public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
		{
			int genIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
			if (genIndex == -1)
			{
				return;
			}

			// Because world generation is like layering several images ontop of each other, we need to do some steps between the original world generation steps.

			// The first step is an Ore. Most vanilla ores are generated in a step called "Shinies", so for maximum compatibility, we will also do this.
			// First, we find out which step "Shinies" is.
			int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
			if (ShiniesIndex != -1)
			{
				// Next, we insert our step directly after the original "Shinies" step.
				// ExampleModOres is a method seen below.
				tasks.Insert(ShiniesIndex + 1, new PassLegacy("Submerging Crystals", SeafoamCrystals));
				// Next, we insert our step directly after the original "Shinies" step.
				// ExampleModOres is a method seen below.
				tasks.Insert(ShiniesIndex + 1, new PassLegacy("Generating Trenagon", TrenagonOre));
				tasks.Insert(ShiniesIndex + 1, new PassLegacy("Generating Phasite", PhasiteOre));
				tasks.Insert(ShiniesIndex + 1, new PassLegacy("Generating Parephene", ParepheneOre));
				tasks.Insert(ShiniesIndex + 1, new PassLegacy("Darkening Diamonds", ShadowCrystal));
				tasks.Insert(ShiniesIndex + 1, new PassLegacy("Generating Neonium", NeoniumOre));
			}

			tasks.Insert(genIndex + 1, new PassLegacy("Ruin", delegate (GenerationProgress progress)
			{
				progress.Message = "Destroying Civilizations";
				for (int i = 3; i < Main.maxTilesX / 1400; i++)       //900 is how many biomes. the bigger is the number = less biomes
				{
					int X = WorldGen.genRand.Next(3, Main.maxTilesX - 1000);
					int Y = WorldGen.genRand.Next((int)WorldGen.rockLayer - -500, Main.maxTilesY - (int)WorldGen.rockLayer - -600);
					int TileType = mod.TileType("AncientStone");     //this is the tile u want to use for the biome , if u want to use a vanilla tile then its int TileType = 56; 56 is obsidian block

					WorldGen.TileRunner(X, Y, 400, WorldGen.genRand.Next(2, 3), TileType, false, 1f, 2f, true, true);  //350 is how big is the biome     100, 200 this changes how random it looks.
				}
			}));
			tasks.Insert(genIndex + 1, new PassLegacy("LuminescentLagoon", delegate (GenerationProgress progress)
			{
				progress.Message = "Illuminating The Underground";
				for (int i = 0; i < Main.maxTilesX / 1300; i++)       //900 is how many biomes. the bigger is the number = less biomes
				{
					int X = WorldGen.genRand.Next(1, Main.maxTilesX - 800);
					int Y = WorldGen.genRand.Next((int)WorldGen.rockLayer - -400, Main.maxTilesY - (int)WorldGen.rockLayer - -500);
					int TileType = mod.TileType("LuminescentRock");     //this is the tile u want to use for the biome , if u want to use a vanilla tile then its int TileType = 56; 56 is obsidian block

					WorldGen.TileRunner(X, Y, 300, WorldGen.genRand.Next(1, 2), TileType, false, 0f, 0f, true, true);  //350 is how big is the biome     100, 200 this changes how random it looks.
				}
			}
			));
		}

		private void SeafoamCrystals(GenerationProgress progress)
		{
			// progress.Message is the message shown to the user while the following code is running. Try to make your message clear. You can be a little bit clever, but make sure it is descriptive enough for troubleshooting purposes.
			progress.Message = "Submerging Crystals";

			// Ores are quite simple, we simply use a for loop and the WorldGen.TileRunner to place splotches of the specified Tile in the world.
			// "6E-05" is "scientific notation". It simply means 0.00006 but in some ways is easier to read.
			for (int k = 0; k < (int)(Main.maxTilesX * Main.maxTilesY * 6E-05); k++)
			{
				// The inside of this for loop corresponds to one single splotch of our Ore.
				// First, we randomly choose any coordinate in the world by choosing a random x and y value.
				int x = WorldGen.genRand.Next(0, Main.maxTilesX);
				int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY); // WorldGen.worldSurfaceLow is actually the highest surface tile. In practice you might want to use WorldGen.rockLayer or other WorldGen values.

				// Then, we call WorldGen.TileRunner with random "strength" and random "steps", as well as the Tile we wish to place. Feel free to experiment with strength and step to see the shape they generate.
				//WorldGen.TileRunner(x, y, (double)WorldGen.genRand.Next(3, 6), WorldGen.genRand.Next(2, 6), mod.TileType("SeafoamStone"), false, 0f, 0f, false, true);

				// Alternately, we could check the tile already present in the coordinate we are interested. Wrapping WorldGen.TileRunner in the following condition would make the ore only generate in Snow.
				Tile tile = Framing.GetTileSafely(x, y);

				if (tile.active() && tile.type == mod.TileType("LuminescentRock"))
					WorldGen.TileRunner(x, y, 10, WorldGen.genRand.Next(50, 100), mod.TileType("SeafoamStone"), false, 0f, 0f, true, true);
			}
		}

		private void TrenagonOre(GenerationProgress progress)
		{
			// progress.Message is the message shown to the user while the following code is running. Try to make your message clear. You can be a little bit clever, but make sure it is descriptive enough for troubleshooting purposes.
			progress.Message = "Trenagon Ore Generating";

			// Ores are quite simple, we simply use a for loop and the WorldGen.TileRunner to place splotches of the specified Tile in the world.
			// "6E-05" is "scientific notation". It simply means 0.00006 but in some ways is easier to read.
			for (int k = 0; k < (int)(Main.maxTilesX * Main.maxTilesY * 6E-05); k++)
			{
				// The inside of this for loop corresponds to one single splotch of our Ore.
				// First, we randomly choose any coordinate in the world by choosing a random x and y value.
				int x = WorldGen.genRand.Next(5, Main.maxTilesX - 400);
				int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY); // WorldGen.worldSurfaceLow is actually the highest surface tile. In practice you might want to use WorldGen.rockLayer or other WorldGen values.

				// Then, we call WorldGen.TileRunner with random "strength" and random "steps", as well as the Tile we wish to place. Feel free to experiment with strength and step to see the shape they generate.
				WorldGen.TileRunner(x, y, WorldGen.genRand.Next(6, 8), WorldGen.genRand.Next(4, 6), mod.TileType("TrenagonOre"), false, 0f, 0f, false, true);

				// Alternately, we could check the tile already present in the coordinate we are interested. Wrapping WorldGen.TileRunner in the following condition would make the ore only generate in Snow.
				// Tile tile = Framing.GetTileSafely(x, y);
				// if (tile.active() && tile.type == TileID.SnowBlock)
				// {
				// 	WorldGen.TileRunner(.....);
				// }
			}
		}

		private void ParepheneOre(GenerationProgress progress)
		{
			// progress.Message is the message shown to the user while the following code is running. Try to make your message clear. You can be a little bit clever, but make sure it is descriptive enough for troubleshooting purposes.
			progress.Message = "Parephene Ore Generating";

			// Ores are quite simple, we simply use a for loop and the WorldGen.TileRunner to place splotches of the specified Tile in the world.
			// "6E-05" is "scientific notation". It simply means 0.00006 but in some ways is easier to read.
			for (int k = 0; k < (int)(Main.maxTilesX * Main.maxTilesY * 6E-05); k++)
			{
				// The inside of this for loop corresponds to one single splotch of our Ore.
				// First, we randomly choose any coordinate in the world by choosing a random x and y value.
				int x = WorldGen.genRand.Next(10, Main.maxTilesX - 800);
				int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY); // WorldGen.worldSurfaceLow is actually the highest surface tile. In practice you might want to use WorldGen.rockLayer or other WorldGen values.

				// Then, we call WorldGen.TileRunner with random "strength" and random "steps", as well as the Tile we wish to place. Feel free to experiment with strength and step to see the shape they generate.
				WorldGen.TileRunner(x, y, WorldGen.genRand.Next(5, 7), WorldGen.genRand.Next(6, 8), mod.TileType("ParepheneOre"), false, 0f, 0f, false, true);

				// Alternately, we could check the tile already present in the coordinate we are interested. Wrapping WorldGen.TileRunner in the following condition would make the ore only generate in Snow.
				// Tile tile = Framing.GetTileSafely(x, y);
				// if (tile.active() && tile.type == TileID.SnowBlock)
				// {
				// 	WorldGen.TileRunner(.....);
				// }
			}
		}

		private void PhasiteOre(GenerationProgress progress)
		{
			// progress.Message is the message shown to the user while the following code is running. Try to make your message clear. You can be a little bit clever, but make sure it is descriptive enough for troubleshooting purposes.
			progress.Message = "Phasite Ore Generating";

			// Ores are quite simple, we simply use a for loop and the WorldGen.TileRunner to place splotches of the specified Tile in the world.
			// "6E-05" is "scientific notation". It simply means 0.00006 but in some ways is easier to read.
			for (int k = 0; k < (int)(Main.maxTilesX * Main.maxTilesY * 6E-05); k++)
			{
				// The inside of this for loop corresponds to one single splotch of our Ore.
				// First, we randomly choose any coordinate in the world by choosing a random x and y value.
				int x = WorldGen.genRand.Next(7, Main.maxTilesX - 600);
				int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY); // WorldGen.worldSurfaceLow is actually the highest surface tile. In practice you might want to use WorldGen.rockLayer or other WorldGen values.

				// Then, we call WorldGen.TileRunner with random "strength" and random "steps", as well as the Tile we wish to place. Feel free to experiment with strength and step to see the shape they generate.
				WorldGen.TileRunner(x, y, WorldGen.genRand.Next(7, 9), WorldGen.genRand.Next(4, 6), mod.TileType("PhasiteOre"), false, 0f, 0f, false, true);

				// Alternately, we could check the tile already present in the coordinate we are interested. Wrapping WorldGen.TileRunner in the following condition would make the ore only generate in Snow.
				// Tile tile = Framing.GetTileSafely(x, y);
				// if (tile.active() && tile.type == TileID.SnowBlock)
				// {
				// 	WorldGen.TileRunner(.....);
				// }
			}
		}

		private void ShadowCrystal(GenerationProgress progress)
		{
			// progress.Message is the message shown to the user while the following code is running. Try to make your message clear. You can be a little bit clever, but make sure it is descriptive enough for troubleshooting purposes.
			progress.Message = "Shadow Crystals Generating";

			// Ores are quite simple, we simply use a for loop and the WorldGen.TileRunner to place splotches of the specified Tile in the world.
			// "6E-05" is "scientific notation". It simply means 0.00006 but in some ways is easier to read.
			for (int k = 0; k < (int)(Main.maxTilesX * Main.maxTilesY * 6E-05); k++)
			{
				// The inside of this for loop corresponds to one single splotch of our Ore.
				// First, we randomly choose any coordinate in the world by choosing a random x and y value.
				int x = WorldGen.genRand.Next(5, Main.maxTilesX);
				int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY); // WorldGen.worldSurfaceLow is actually the highest surface tile. In practice you might want to use WorldGen.rockLayer or other WorldGen values.

				// Then, we call WorldGen.TileRunner with random "strength" and random "steps", as well as the Tile we wish to place. Feel free to experiment with strength and step to see the shape they generate.
				WorldGen.TileRunner(x, y, WorldGen.genRand.Next(2, 4), WorldGen.genRand.Next(2, 4), mod.TileType("ShadowCrystalOre"), false, 0f, 0f, false, true);

				// Alternately, we could check the tile already present in the coordinate we are interested. Wrapping WorldGen.TileRunner in the following condition would make the ore only generate in Snow.
				// Tile tile = Framing.GetTileSafely(x, y);
				// if (tile.active() && tile.type == TileID.SnowBlock)
				// {
				// 	WorldGen.TileRunner(.....);
				// }
			}
		}

		private void NeoniumOre(GenerationProgress progress)
		{
			// progress.Message is the message shown to the user while the following code is running. Try to make your message clear. You can be a little bit clever, but make sure it is descriptive enough for troubleshooting purposes.
			progress.Message = "Neonium Ore Generating";

			// Ores are quite simple, we simply use a for loop and the WorldGen.TileRunner to place splotches of the specified Tile in the world.
			// "6E-05" is "scientific notation". It simply means 0.00006 but in some ways is easier to read.
			for (int k = 0; k < (int)(Main.maxTilesX * Main.maxTilesY * 6E-05); k++)
			{
				// The inside of this for loop corresponds to one single splotch of our Ore.
				// First, we randomly choose any coordinate in the world by choosing a random x and y value.
				int x = WorldGen.genRand.Next(5, Main.maxTilesX - 500);
				int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY); // WorldGen.worldSurfaceLow is actually the highest surface tile. In practice you might want to use WorldGen.rockLayer or other WorldGen values.

				// Then, we call WorldGen.TileRunner with random "strength" and random "steps", as well as the Tile we wish to place. Feel free to experiment with strength and step to see the shape they generate.
				WorldGen.TileRunner(x, y, WorldGen.genRand.Next(6, 8), WorldGen.genRand.Next(4, 6), mod.TileType("NeoniumOre"), false, 0f, 0f, false, true);

				// Alternately, we could check the tile already present in the coordinate we are interested. Wrapping WorldGen.TileRunner in the following condition would make the ore only generate in Snow.
				// Tile tile = Framing.GetTileSafely(x, y);
				// if (tile.active() && tile.type == TileID.SnowBlock)
				// {
				// 	WorldGen.TileRunner(.....);
				// }
			}
		}
	}
}