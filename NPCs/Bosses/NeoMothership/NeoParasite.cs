using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.NPCs.Bosses.NeoMothership
{
	[AutoloadBossHead]
	public class NeoParasite : ModNPC
	{
		private Random rand = new Random();

		private int preDir = 5;

		private bool debug = false;

		private bool hasSpawned = false;

		private float speed;

		private int phase = 0;

		private Player player;

		private int attackTimer = 10;

		private int count = 0;

		private float heightMod = -60f;

		private Vector2 shootDirection = new Vector2(1, 0);

		private float verticalFlySpeed = 0.01f;

		private int _despawn = 0;

		private float tpX = 350;

		//These two should always be the same
		private int tpTimer = 3000;

		private int tpMax = 3000;

		private int frame = 0;

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Neo Parasite");
			Main.npcFrameCount[npc.type] = 6;
		}

		//

		public override void SetDefaults()
		{
			npc.width = 80;
			npc.height = 96;
			npc.damage = 40;
			npc.lifeMax = 10000;
			npc.life = 10000;
			npc.defense = 0;
			phase = 1;
			_despawn = 0;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 1000f;
			npc.knockBackResist = 0f;
			npc.boss = true;
			Lighting.AddLight(npc.Center, 0f, 2f, 0f);
			music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/NeoParasiteTheme");
			bossBag = mod.ItemType("NeoParasiteTreasureBag");
			npc.lavaImmune = true;
			npc.noGravity = true;
			npc.noTileCollide = true;
		}

		public override void NPCLoot()
		{
			if (!Main.expertMode)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("NeoPickaxe"));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("NeoniumBar"), Main.rand.Next(10, 15));
			}

			if (MyWorld.neonium == false)
			{
				MyWorld.neonium = true;
				Main.NewText("The world is infected with a mysterious green glow.", 0, 200, 0);
				for (int k = 0; k < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 6E-05); k++)
				{
					// The inside of this for loop corresponds to one single splotch of our Ore.
					// First, we randomly choose any coordinate in the world by choosing a random x and y value.
					int x = WorldGen.genRand.Next(5, Main.maxTilesX - 300);
					int y = WorldGen.genRand.Next((int)WorldGen.rockLayer, Main.maxTilesY); // WorldGen.worldSurfaceLow is actually the highest surface tile. In practice you might want to use WorldGen.rockLayer or other WorldGen values.

					// Then, we call WorldGen.TileRunner with random "strength" and random "steps", as well as the Tile we wish to place. Feel free to experiment with strength and step to see the shape they generate.
					WorldGen.TileRunner(x, y, (double)WorldGen.genRand.Next(5, 6), WorldGen.genRand.Next(7, 8), mod.TileType("NeoniumOre"), false, 0f, 0f, false, true);

					// Alternately, we could check the tile already present in the coordinate we are interested. Wrapping WorldGen.TileRunner in the following condition would make the ore only generate in Snow.
					// Tile tile = Framing.GetTileSafely(x, y);
					// if (tile.active() && tile.type == TileID.SnowBlock)
					// {
					// 	WorldGen.TileRunner(.....);
					// }
				}
				/* {
                     int loots2 = Main.rand.Next(10);
                     switch (loots2)
                     {
                         case 1: Item.NewItem(npc.getRect(), mod.ItemType("GiantSandSifterTrophy"), 1); break;
                         case 2: break;
                     }*/
			}
			MyWorld.downedNeoMothership = true;
			if (Main.expertMode)
			{
				npc.DropBossBags();
			}
		}

		public override void AI()
		{
			Player player = Main.player[npc.target];
			if (npc.target < 0 || npc.target == 255 || Main.player[npc.target].dead || !Main.player[npc.target].active)
			{
				npc.TargetClosest(true);
			}
			npc.netUpdate = true;

			//DESPAWN
			if (!Main.player[npc.target].active || Main.player[npc.target].dead)
			{
				npc.TargetClosest(true);
				if (!Main.player[npc.target].active || Main.player[npc.target].dead)
				{
					if (_despawn == 0)
						_despawn++;
				}
			}

			Target();
			Vector2 moveDirection = new Vector2(npc.Center.X, npc.Center.Y);
			//tp stuff
			if (tpTimer >= tpMax / 2)
			{
				npc.position = new Vector2(player.Center.X + tpX, player.Center.Y + heightMod);
				shootDirection = new Vector2(1, npc.Center.Y);
			}
			if (tpTimer < tpMax / 2)
			{
				npc.position = new Vector2(player.Center.X - tpX, player.Center.Y + heightMod);
				shootDirection = new Vector2(npc.Center.X + 100, npc.Center.Y);
			}
			if (tpTimer == 0)
			{
				tpTimer = tpMax;
			}
			tpTimer--;

			//shoot stuff
			float wantedSpeed = 15f;
			Vector2 shootVelocity = npc.DirectionTo(shootDirection) * wantedSpeed;
			attackTimer--;
			if (attackTimer == 0)
			{
				attackTimer = rand.Next(1, 10);
				if (count == 0)
				{
					count = 7;
					Projectile.NewProjectile(npc.Center, shootVelocity, mod.ProjectileType("NeonBeam"), 15, 5, Main.LocalPlayer.whoAmI);
				}
				count--;
			}
		}

		public override void FindFrame(int frameHeight)
		{
			npc.frameCounter++;
			if (npc.frameCounter > 6)
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