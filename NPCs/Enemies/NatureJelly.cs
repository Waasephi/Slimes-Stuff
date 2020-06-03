using OurStuffAddon.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.NPCs.Enemies
{
	public class NatureJelly : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nature Jelly");
			Main.npcFrameCount[npc.type] = 5;
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 46;
			npc.damage = 15;
			npc.lifeMax = 50;
			npc.life = 50;
			npc.defense = 2;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 100f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			aiType = NPCID.Zombie;
			animationType = NPCID.Zombie;
		}

		public override void NPCLoot()
		{
			int loots = Main.rand.Next(3);
			switch (loots)
			{
				case 1:
					Item.NewItem(npc.getRect(), ModContent.ItemType<EnchantedLeaf>(), Main.rand.Next(2));
					break;
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			// we would like this npc to spawn in the overworld.
			return SpawnCondition.OverworldDaySlime.Chance * 0.5f;
		}
	}
}