using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.NPCs.Enemies
{
   	public class AncientMimic : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Mimic");
            Main.npcFrameCount[npc.type] = 24;
        }

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 46;
            npc.damage = 50;
            npc.lifeMax = 400;
            npc.life = 400;
			npc.defense = 20;
			npc.HitSound = SoundID.NPCHit4;
			npc.DeathSound = SoundID.NPCDeath3;
			npc.value = 10000f;
			npc.knockBackResist = 1;
			npc.aiStyle = 25;
			aiType = NPCID.Mimic;
			animationType = NPCID.Mimic;
		}
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.player.GetModPlayer<OurStuffAddonPlayer>().ZoneRuin ? 0.2f : 0f;
        }
        public override void NPCLoot()
        {
            int loots = Main.rand.Next(6);
            switch (loots)
            {
                case 1:
                    Item.NewItem(npc.getRect(), mod.ItemType("Relicarver"), Main.rand.Next(1, 1));
                    break;
                case 2:
                    Item.NewItem(npc.getRect(), mod.ItemType("RelicChakram"), Main.rand.Next(1, 1));
                    break;
                case 3:
                    Item.NewItem(npc.getRect(), mod.ItemType("RuinedRelic"), Main.rand.Next(1, 1));
                    break;
                case 4:
                    Item.NewItem(npc.getRect(), mod.ItemType("RelicStaff"), Main.rand.Next(1, 1));
                    break;
                case 5:
                    Item.NewItem(npc.getRect(), mod.ItemType("RelicSword"), Main.rand.Next(1, 1));
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
    }
    
}