using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.NPCs.Enemies
{
   	public class SeafoamSlime : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Seafoam Slime");
            Main.npcFrameCount[npc.type] = 2;
        }

		public override void SetDefaults()
		{
			npc.width = 38;
			npc.height = 28;
            npc.damage = 30;
            npc.lifeMax = 350;
            npc.life = 350;
			npc.defense = 0;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 100f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 1;
			aiType = NPCID.BlueSlime;
			animationType = NPCID.BlueSlime;
            Lighting.AddLight(npc.Center, 0, 1.5f, 2f);
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.player.GetModPlayer<OurStuffAddonPlayer>().ZoneLuminescentLagoon ? 0.2f : 0f;
        }
        public override void NPCLoot()
        {
            int loots = Main.rand.Next(2);
            switch (loots)
            {
                case 1:
                    Item.NewItem(npc.getRect(), mod.ItemType("SeafoamCrystal"), Main.rand.Next(2, 3));
                    break;
            }
        }
    }
}