using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.NPCs.Bosses.LifeEnforcer
{
   	public class EnforcerAssister : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Enforcer Assister");
            Main.npcFrameCount[npc.type] = 22;
        }

		public override void SetDefaults()
		{
			npc.width = 40;
			npc.height = 40;
            npc.damage = 25;
            npc.lifeMax = 500;
            npc.life = 500;
			npc.defense = 0;
			npc.HitSound = SoundID.NPCHit17;
			npc.DeathSound = SoundID.NPCDeath14;
			npc.value = 100f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 91;
			aiType = NPCID.GraniteFlyer;
			animationType = NPCID.GraniteFlyer;
            Lighting.AddLight(npc.Center, 2f, 2f, 2f);
        }
    }
}