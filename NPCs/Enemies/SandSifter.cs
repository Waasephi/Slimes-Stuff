using System.IO;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.NPCs.Enemies
{
	// I made this 2nd base class to limit code repetition.
	public abstract class SandSifter : Worm
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sand Sifter");
		}

		public override void Init()
		{
			minLength = 10;
			maxLength = 20;
			tailType = ModContent.NPCType<SandSifterTail>();
			bodyType = ModContent.NPCType<SandSifterBody>();
			headType = ModContent.NPCType<SandSifterHead>();
			speed = 2.0f;
			turnSpeed = 0.1f;
			npc.buffImmune[24] = false;
		}

		public override void NPCLoot()
		{
			int loots = Main.rand.Next(2);
			switch (loots)
			{
				case 1:
					Item.NewItem(npc.getRect(), mod.ItemType("SandSifterScale"), Main.rand.Next(2, 3));
					break;
			}
		}
	}

	internal class SandSifterHead : SandSifter
	{
		private int attackCounter = 0;

		public override string Texture => "OurStuffAddon/NPCs/Enemies/SandSifterHead";

		public override void SetDefaults()
		{
			npc.CloneDefaults(NPCID.DiggerHead);
			npc.width = 40;
			npc.height = 48;
			npc.damage = 10;
			npc.defense = 5;
			npc.lifeMax = 300;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.aiStyle = -1;
			npc.lavaImmune = true;
			npc.buffImmune[24] = true;
		}

		public override void Init()
		{
			base.Init();
			head = true;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return spawnInfo.player.ZoneUndergroundDesert && NPC.downedBoss1 ? 0.1f : 0f;
		}

		public override void SendExtraAI(BinaryWriter writer)
		{
			writer.Write(attackCounter);
		}

		public override void ReceiveExtraAI(BinaryReader reader)
		{
			attackCounter = reader.ReadInt32();
		}

		public override void CustomBehavior()
		{
		}
	}

	internal class SandSifterBody : SandSifter
	{
		public override string Texture => "OurStuffAddon/NPCs/Enemies/SandSifterBody";

		public override void SetDefaults()
		{
			npc.CloneDefaults(NPCID.DiggerBody);
			npc.width = 26;
			npc.height = 44;
			npc.damage = 5;
			npc.defense = 15;
			npc.lifeMax = 600;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.aiStyle = -1;
			npc.lavaImmune = true;
			npc.buffImmune[24] = true;
		}
	}

	internal class SandSifterTail : SandSifter
	{
		public override string Texture => "OurStuffAddon/NPCs/Enemies/SandSifterTail";

		public override void SetDefaults()
		{
			npc.CloneDefaults(NPCID.DiggerTail);
			npc.width = 26;
			npc.height = 52;
			npc.damage = 10;
			npc.defense = 13;
			npc.lifeMax = 600;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.aiStyle = -1;
			npc.lavaImmune = true;
			npc.buffImmune[24] = true;
		}

		public override void Init()
		{
			base.Init();
			tail = true;
		}
	}
}