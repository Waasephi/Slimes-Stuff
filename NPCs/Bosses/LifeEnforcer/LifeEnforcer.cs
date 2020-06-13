using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.NPCs.Bosses.LifeEnforcer
{
	[AutoloadBossHead]
	public class LifeEnforcer : ModNPC
	{
		public int phase = 0;

		private Player player;

		private int count = 0;

		private float speed;

		private int attackTimer = 20;

		private int frame = 0;

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Life Enforcer");
			Main.npcFrameCount[npc.type] = 10;
		}

		public override void SetDefaults()
		{
			phase = 1;
			npc.width = 75;
			npc.height = 90;
			npc.damage = 40;
			npc.lifeMax = 2000;
			npc.life = 2000;
			npc.boss = true;
			npc.defense = 0;
			npc.HitSound = SoundID.NPCHit41;
			npc.DeathSound = SoundID.NPCDeath14;
			npc.value = 10000f;
			npc.knockBackResist = 0f;
			Lighting.AddLight(npc.Center, 3f, 2f, 2f);
			music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/LifeEnforcerTheme");
			bossBag = mod.ItemType("LifeEnforcerTreasureBag"); //todo modcontent
			npc.lavaImmune = true;
			npc.noGravity = true;
			npc.noTileCollide = true;
		}

		public override void NPCLoot()
		{
			//todo modcontent
			if (!Main.expertMode)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MineralChunk"), Main.rand.Next(3, 5));
			}

			/* {
                 int loots2 = Main.rand.Next(10);
                 switch (loots2)
                 {
                     case 1: Item.NewItem(npc.getRect(), mod.ItemType("GiantSandSifterTrophy"), 1); break;
                     case 2: break;
                 }
             }*/

			MyWorld.downedLifeEnforcer = true;
			if (Main.expertMode)
			{
				npc.DropBossBags();
			}
			if (MyWorld.heartStone == false)
			{
				MyWorld.heartStone = true;
				Main.NewText("Life bursts through the world", 250, 200, 200);

				// Ores are quite simple, we simply use a for loop and the WorldGen.TileRunner to place splotches of the specified Tile in the world.
				// "6E-05" is "scientific notation". It simply means 0.00006 but in some ways is easier to read.
				for (int k = 0; k < (int)(Main.maxTilesX * Main.maxTilesY * 6E-05); k++)
				{
					// The inside of this for loop corresponds to one single splotch of our Ore.
					// First, we randomly choose any coordinate in the world by choosing a random x and y value.
					int x = WorldGen.genRand.Next(5, Main.maxTilesX - 500);
					int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY); // WorldGen.worldSurfaceLow is actually the highest surface tile. In practice you might want to use WorldGen.rockLayer or other WorldGen values.

					// Then, we call WorldGen.TileRunner with random "strength" and random "steps", as well as the Tile we wish to place. Feel free to experiment with strength and step to see the shape they generate.
					WorldGen.TileRunner(x, y, WorldGen.genRand.Next(2, 3), WorldGen.genRand.Next(4, 6), mod.TileType("HeartStone"), false, 0f, 0f, false, true);
					//todo modcontent
					// Alternately, we could check the tile already present in the coordinate we are interested. Wrapping WorldGen.TileRunner in the following condition would make the ore only generate in Snow.
					// Tile tile = Framing.GetTileSafely(x, y);
					// if (tile.active() && tile.type == TileID.SnowBlock)
					// {
					// 	WorldGen.TileRunner(.....);
				}
			}
		}

		public override bool PreAI()
		{
			npc.TargetClosest(true);
			return true;
		}

		public override void AI()
		{
			Target();
			Move();

			float wantedSpeed = 9f;
			Vector2 shootVelocity = npc.DirectionTo(player.Center) * wantedSpeed;

			attackTimer--;

			if (attackTimer == 0)
			{
				attackTimer = 30;
				if (count == 0)
				{
					count = 20;
					Projectile.NewProjectile(npc.Center, shootVelocity, mod.ProjectileType("LifeBlast"), 4, 5, Main.LocalPlayer.whoAmI);
				}//todo modcontent
				count--;
			}
		}

		public override void BossLoot(ref string name, ref int potionType)
		{
			if (MyWorld.downedLifeEnforcer)
			{
				Main.NewText("I could not stop it...", 250, 200, 200);
			}
		}

		public override void FindFrame(int frameHeight)
		{
			npc.frameCounter++;
			if (npc.frameCounter > 7)
			{  //7 frames between each "frame" of animation
				npc.frameCounter = 0;
				frame++;
				if (frame >= Main.npcFrameCount[npc.type])
				{
					frame = 0;
				}
			}
			npc.frame.Y = frame * frameHeight;
		}

		private void Move()
		{
			speed = 6f;
			Vector2 goalPosition = player.Center;
			Vector2 move = goalPosition - npc.Center;
			float magnitude = Magnitude(move);
			if (magnitude > speed)
			{
				move *= speed / magnitude;
			}
			float turnResistance = 10f;
			move = (npc.velocity * turnResistance + move) / (turnResistance + 1f);
			magnitude = Magnitude(move);
			if (magnitude > speed)
			{
				move *= speed / magnitude;
			}
			npc.velocity = move;
		}

		private float Magnitude(Vector2 mag)
		{
			return (float)Math.Sqrt(mag.X * mag.X + mag.Y * mag.Y);
		}

		private void Target()
		{
			player = Main.player[npc.target];
		}
	}
}