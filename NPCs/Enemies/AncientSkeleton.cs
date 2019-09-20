using System;
using System.IO;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Terraria.GameContent.Generation;
using Terraria.ModLoader.IO;

namespace OurStuffAddon.NPCs.Enemies
{
   	public class AncientSkeleton : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Skeleton");
            Main.npcFrameCount[npc.type] = 15;
        }

		public override void SetDefaults()
		{
			npc.width = 40;
			npc.height = 56;
            npc.damage = 30;
            npc.lifeMax = 200;
            npc.life = 200;
			npc.defense = 8;
			npc.HitSound = SoundID.NPCHit2;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 100f;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			aiType = NPCID.ArmoredSkeleton;
			animationType = NPCID.Skeleton;
		}

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            return spawnInfo.player.GetModPlayer<OurStuffAddonPlayer>().ZoneRuin ? 0.4f : 0f;
        }
    }
}