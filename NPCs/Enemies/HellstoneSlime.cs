using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.NPCs.Enemies
{
   	public class HellstoneSlime : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hellstone Slime");
            Main.npcFrameCount[npc.type] = 2;
        }

		public override void SetDefaults()
		{
			npc.width = 38;
			npc.height = 28;
            npc.damage = 20;
            npc.lifeMax = 200;
            npc.life = 200;
			npc.defense = 5;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 100f;
			npc.knockBackResist = 0.5f;
            npc.lavaImmune = true;
            npc.buffImmune[24] = true;
            npc.aiStyle = 1;
			aiType = NPCID.BlueSlime;
			animationType = NPCID.BlueSlime;
        }
        public override void OnHitPlayer(Player target, int dmgDealt, bool crit)
        {
            int debuff = BuffID.OnFire;
            if (debuff >= 0)
            {
                target.AddBuff(debuff, 20, true);
            }
        }
        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.player.ZoneUnderworldHeight && NPC.downedBoss2 ? 0.1f : 0f;
        }
        public override void NPCLoot()
        {
            int loots = Main.rand.Next(2);
            switch (loots)
            {
                case 1:
                    Item.NewItem(npc.getRect(), ItemID.Hellstone, Main.rand.Next(1, 5)); break;
            }
        }
    }
}