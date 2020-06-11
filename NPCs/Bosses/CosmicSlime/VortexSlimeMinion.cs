using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.NPCs.Bosses.CosmicSlime
{
	public class VortexSlimeMinion : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vortex Slime Minion");
			Main.npcFrameCount[npc.type] = 2;
		}

		public override void SetDefaults()
		{
			npc.width = 132;
			npc.height = 99;
			npc.damage = 30;
			npc.lifeMax = 50000;
			npc.life = 50000;
			npc.defense = 0;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 100f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 1;
			aiType = NPCID.BlueSlime;
			animationType = NPCID.BlueSlime;
			Lighting.AddLight(npc.Center, 4f, 2f, 0f);
		}
	}
}