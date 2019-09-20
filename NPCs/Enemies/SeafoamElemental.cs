using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.NPCs.Enemies
{
   	public class SeafoamElemental : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Seafoam Elemental");
            Main.npcFrameCount[npc.type] = 22;
        }

		public override void SetDefaults()
		{
			npc.width = 27;
			npc.height = 27;
            npc.damage = 25;
            npc.lifeMax = 700;
            npc.life = 700;
			npc.defense = 3;
			npc.HitSound = SoundID.NPCHit7;
			npc.DeathSound = SoundID.NPCDeath14;
			npc.value = 100f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 91;
			aiType = NPCID.GraniteFlyer;
			animationType = NPCID.GraniteFlyer;
            Lighting.AddLight(npc.Center, 0f, 2f, 1f);
        }
        public override void NPCLoot()
        {
            int loots = Main.rand.Next(2);
            switch (loots)
            {
                case 1:
                    Item.NewItem(npc.getRect(), mod.ItemType("SeafoamShard"), Main.rand.Next(2, 3));
                    break;
            }
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.player.GetModPlayer<OurStuffAddonPlayer>().ZoneLuminescentLagoon ? 0.2f : 0f;
        }
    }
}