using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.NPCs.Enemies
{
	public class AncientSkeleton : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Skeleton");
			Main.npcFrameCount[npc.type] = 15;
		}

		public override void SetDefaults()
		{
			npc.width = 40;
			npc.height = 56;
			npc.damage = 30;
			npc.lifeMax = 200;
			npc.life = 200;
			npc.defense = 8;
			npc.HitSound = SoundID.NPCHit2;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 100f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			aiType = NPCID.ArmoredSkeleton;
			animationType = NPCID.Skeleton;
		}

		public override void NPCLoot()
		{
			int loots = Main.rand.Next(2);
			switch (loots)
			{
				case 1:
					Item.NewItem(npc.getRect(), ModContent.ItemType<RelicShard>(), Main.rand.Next(2, 3));
					break;
			}
			int loots2 = Main.rand.Next(3);
			if (Main.hardMode) ;
			switch (loots2)
			{
				case 1:
					Item.NewItem(npc.getRect(), ModContent.ItemType<SoulofAntiquity>(), Main.rand.Next(1, 1));
					break;
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return spawnInfo.player.GetModPlayer<MyPlayer>().ZoneRuin ? 0.4f : 0f;
		}
	}
}