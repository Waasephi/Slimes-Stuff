using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.NPCs.Enemies
{
	public class LuminescentJelly : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Luminescent Jelly");
			Main.npcFrameCount[npc.type] = 7;
		}

		public override void SetDefaults()
		{
			npc.width = 56;
			npc.height = 46;
			npc.damage = 30;
			npc.lifeMax = 250;
			npc.life = 250;
			npc.defense = 0;
			npc.HitSound = SoundID.NPCHit25;
			npc.DeathSound = SoundID.NPCDeath28;
			npc.value = 100f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 18;
			aiType = NPCID.BlueJellyfish;
			animationType = NPCID.BlueJellyfish;
			Lighting.AddLight(npc.Center, 0, 1.5f, 2f);
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return spawnInfo.player.GetModPlayer<OurStuffAddonPlayer>().ZoneLuminescentLagoon ? 0.3f : 0f;
		}

		public override void NPCLoot()
		{
			int loots = Main.rand.Next(2);
			switch (loots)
			{
				case 1:
					Item.NewItem(npc.getRect(), mod.ItemType("SeafoamScale"), Main.rand.Next(2, 3));
					break;
			}
		}
	}
}