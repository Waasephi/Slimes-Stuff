using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.NPCs.Enemies
{
	public class LuminescentPiranha : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Luminescent Piranha");
			Main.npcFrameCount[npc.type] = 6;
		}

		public override void SetDefaults()
		{
			npc.width = 38;
			npc.height = 28;
			npc.damage = 30;
			npc.lifeMax = 300;
			npc.life = 300;
			npc.defense = 0;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 100f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 16;
			aiType = NPCID.Piranha;
			animationType = NPCID.Piranha;
			Lighting.AddLight(npc.Center, 0, 1.5f, 2f);
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return spawnInfo.player.GetModPlayer<MyPlayer>().ZoneLuminescentLagoon ? 0.3f : 0f;
		}

		public override void NPCLoot()
		{
			int loots = Main.rand.Next(2);
			switch (loots)
			{
				case 1:
					Item.NewItem(npc.getRect(), ModContent.ItemType<SeafoamScale>(), Main.rand.Next(2, 3));
					break;
			}
		}
	}
}