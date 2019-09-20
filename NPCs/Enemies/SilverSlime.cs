using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.NPCs.Enemies
{
   	public class SilverSlime : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Silver Slime");
            Main.npcFrameCount[npc.type] = 2;
        }

		public override void SetDefaults()
		{
			npc.width = 38;
			npc.height = 28;
            npc.damage = 9;
            npc.lifeMax = 90;
            npc.life = 90;
			npc.defense = 1;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 100f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 1;
			aiType = NPCID.BlueSlime;
			animationType = NPCID.BlueSlime;
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.player.ZoneRockLayerHeight ? 0.1f : 0f;
        }
        public override void NPCLoot()
        {
            int loots = Main.rand.Next(2);
            switch (loots)
            {
                case 1:
                    Item.NewItem(npc.getRect(), ItemID.SilverOre, Main.rand.Next(1, 5)); break;
            }
        }
    }
}