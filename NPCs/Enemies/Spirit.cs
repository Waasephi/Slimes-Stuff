using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.NPCs.Enemies
{
   	public class Spirit : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spirit");
            Main.npcFrameCount[npc.type] = 8;
        }

		public override void SetDefaults()
		{
			npc.width = 24;
			npc.height = 48;
            npc.damage = 15;
            npc.lifeMax = 100;
            npc.life = 100;
			npc.defense = 4;
			npc.HitSound = SoundID.NPCHit54;
			npc.DeathSound = SoundID.NPCDeath52;
			npc.value = 60f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			aiType = NPCID.Zombie;
			animationType = NPCID.Wraith;
		}
		public override void NPCLoot()
        {
            int loots = Main.rand.Next(11);
            switch (loots)
            {
                case 1: Item.NewItem(npc.getRect(), ItemID.Diamond, 1); break;
                case 2: break;
            }
            int loots2 = Main.rand.Next(4);
            switch (loots2)
            {
                case 2:
                    Item.NewItem(npc.getRect(), mod.ItemType("SpiritShard"), Main.rand.Next(3, 10));
                    break;
            }
            int loots3 = Main.rand.Next(6);
            switch (loots3)
            { 
				case 3:
                    Item.NewItem(npc.getRect(), mod.ItemType("SpiriciteCrystal"), Main.rand.Next(1, 2));

                    break;
			}
            
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldNightMonster.Chance * 0.6f;
		}

	}
}