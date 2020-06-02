using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.NPCs.Bosses
{
	[AutoloadBossHead]
	public class NeoParasite : ModNPC
	{
		public int phase = 0;

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Neo Parasite");
			Main.npcFrameCount[npc.type] = 6;
		}

		public override void SetDefaults()
		{
			npc.width = 44;
			npc.height = 52;
			npc.damage = 40;
			npc.lifeMax = 5000;
			npc.life = 5000;
			npc.defense = 0;
			phase = 1;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 1000f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 49;
			aiType = 420;
			animationType = 420;
			npc.boss = true;
			Lighting.AddLight(npc.Center, 0f, 2f, 0f);
			music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/CosmicSlimeTheme");
			bossBag = mod.ItemType("NeoParasiteTreasureBag");
		}

		public override void NPCLoot()
		{
			if (!Main.expertMode)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("NeoPickaxe"));
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("NeoniumBar"), Main.rand.Next(10, 15));
			}

			/* {
                 int loots2 = Main.rand.Next(10);
                 switch (loots2)
                 {
                     case 1: Item.NewItem(npc.getRect(), mod.ItemType("GiantSandSifterTrophy"), 1); break;
                     case 2: break;
                 }
             }*/
			OurStuffAddonWorld.downedNeoMothership = true;
			if (Main.expertMode)
			{
				npc.DropBossBags();
			}
		}

		public override bool PreAI()
		{
			npc.TargetClosest(true);
			return true;
		}

		public override void BossLoot(ref string name, ref int potionType)
		{
			/*if (OurStuffAddonWorld.HeartStone == false)
            {
                OurStuffAddonWorld.HeartStone = true;
                Main.NewText("Life bursts through the world", 250, 200, 200);
                GenerateHeartStone();
            }*/
		}

		public override void AI()
		{
			//Phases
		}
	}
}