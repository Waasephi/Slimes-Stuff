using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.NPCs.Enemies
{
	public class AncientElemental : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Elemental");
			Main.npcFrameCount[npc.type] = 22;
		}

		public override void SetDefaults()
		{
			npc.width = 40;
			npc.height = 40;
			npc.damage = 25;
			npc.lifeMax = 200;
			npc.life = 200;
			npc.defense = 3;
			npc.HitSound = SoundID.NPCHit7;
			npc.DeathSound = SoundID.NPCDeath14;
			npc.value = 100f;
			npc.knockBackResist = 0.1f;
			npc.aiStyle = 91;
			aiType = NPCID.GraniteFlyer;
			animationType = NPCID.GraniteFlyer;
			Lighting.AddLight(npc.Center, 2f, 2f, 2f);
		}

		public override void NPCLoot()
		{
			int loots = Main.rand.Next(2);
			switch (loots)
			{
				case 1:
					Item.NewItem(npc.getRect(), mod.ItemType("RelicShard"), Main.rand.Next(2, 3));
					break;
			}
			int loots2 = Main.rand.Next(3);
			if (Main.hardMode) ;
			switch (loots2)
			{
				case 1:
					Item.NewItem(npc.getRect(), mod.ItemType("SoulofAntiquity"), Main.rand.Next(1, 1));
					break;
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return spawnInfo.player.GetModPlayer<OurStuffAddonPlayer>().ZoneRuin ? 0.2f : 0f;
		}
	}
}