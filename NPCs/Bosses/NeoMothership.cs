using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.NPCs.Bosses
{
    [AutoloadBossHead]
    public class NeoMothership : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Neo Mothership");
            Main.npcFrameCount[npc.type] = 4;

        }
        public int phase = 0;
        public override void SetDefaults()
        {
            npc.width = 156;
            npc.height = 72;
            npc.damage = 80;
            npc.lifeMax = 10000;
            npc.life = 10000;
            npc.defense = 0;
            phase = 1;
            npc.HitSound = SoundID.NPCHit4;
            npc.DeathSound = SoundID.NPCDeath14;
            npc.value = 1000f;
            npc.knockBackResist = 0f;
            npc.aiStyle = 49;
            aiType = NPCID.AngryNimbus;
            animationType = NPCID.AngryNimbus;
            npc.boss = true;
            Lighting.AddLight(npc.Center, 0f, 2f, 0f);
            music = 37;
        }

        public override bool PreAI()
        {
            npc.TargetClosest(true);
            return true;
        }
        public override void BossLoot(ref string name, ref int potionType)
        {


            /*if (OurStuffAddonWorld.HeartStone == false)
            {
                OurStuffAddonWorld.HeartStone = true;
                Main.NewText("Life bursts through the world", 250, 200, 200);
                GenerateHeartStone();
            }*/
        }

        public override void AI()
        {
            //Phases
            if (npc.life < npc.lifeMax * 0.1f && phase == 1)
            {
                NPC.NewNPC((int)npc.position.X - 50, (int)npc.position.Y, ModContent.NPCType<NeoParasite>());
                phase = 2;
            }
        }
    }
}