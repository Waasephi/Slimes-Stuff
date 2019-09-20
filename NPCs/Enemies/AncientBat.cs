using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.NPCs.Enemies
{
   	public class AncientBat : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Bat");
            Main.npcFrameCount[npc.type] = 5;
        }

		public override void SetDefaults()
		{
			npc.width = 56;
			npc.height = 26;
            npc.damage = 30;
            npc.lifeMax = 500;
            npc.life = 500;
			npc.defense = 0;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath4;
			npc.value = 100f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 14;
			aiType = NPCID.CaveBat;
			animationType = NPCID.CaveBat;
            Lighting.AddLight(npc.Center, 0, 0f, 0f);
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.player.GetModPlayer<OurStuffAddonPlayer>().ZoneRuin ? 0.4f : 0f;
        }
    }
}