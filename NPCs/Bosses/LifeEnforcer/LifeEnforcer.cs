using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using OurStuffAddon.Structures;

namespace OurStuffAddon.NPCs.Bosses.LifeEnforcer
{
    [AutoloadBossHead]
    public class LifeEnforcer : ModNPC
    {
        public override void SetStaticDefaults()
        {

            DisplayName.SetDefault("Life Enforcer");
            Main.npcFrameCount[npc.type] = 20;
        }
        public int phase = 0;
        public override void SetDefaults()
        {
            phase = 1;
            npc.width = 75;
            npc.height = 90;
            npc.damage = 40;
            npc.lifeMax = 2000;
            npc.life = 2000;
            npc.boss = true;
            npc.defense = 0;
            npc.HitSound = SoundID.NPCHit41;
            npc.DeathSound = SoundID.NPCDeath14;
            npc.value = 10000f;
            npc.knockBackResist = 0f;
            npc.aiStyle = 3;
            aiType = NPCID.GraniteGolem;
            animationType = NPCID.GraniteGolem;
            Lighting.AddLight(npc.Center, 3f, 2f, 2f);
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/LifeEnforcerTheme");
            bossBag = mod.ItemType("LifeEnforcerTreasureBag");
            npc.lavaImmune = true;
        }
        public override void NPCLoot()
        {
            if (!Main.expertMode)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("MineralChunk"), Main.rand.Next(3, 5));
            }


            /* {
                 int loots2 = Main.rand.Next(10);
                 switch (loots2)
                 {
                     case 1: Item.NewItem(npc.getRect(), mod.ItemType("GiantSandSifterTrophy"), 1); break;
                     case 2: break;
                 }
             }*/
            OurStuffAddonWorld.downedLifeEnforcer = true;
            if (Main.expertMode)
            {
                npc.DropBossBags();
            }
        }
        public override void AI()
        {
            //Phases
            if (npc.life < npc.lifeMax * .8 && phase == 1)
            {
                phase = 2;
                NPC.NewNPC((int)npc.position.X - 5, (int)npc.position.Y - 0, ModContent.NPCType<EnforcerAssister>());
                NPC.NewNPC((int)npc.position.X - 0, (int)npc.position.Y - 5, ModContent.NPCType<EnforcerAssister>());
                NPC.NewNPC((int)npc.position.X - 0, (int)npc.position.Y - 0, ModContent.NPCType<EnforcerAssister>());
                NPC.NewNPC((int)npc.position.X - 5, (int)npc.position.Y - 5, ModContent.NPCType<EnforcerAssister>());
            }
            if (npc.life < npc.lifeMax * .6 && phase == 2)
            {
                NPC.NewNPC((int)npc.position.X - 5, (int)npc.position.Y, ModContent.NPCType<EnforcerAssister>());
                NPC.NewNPC((int)npc.position.X - 5, (int)npc.position.Y - 5, ModContent.NPCType<EnforcerAssister>());
                NPC.NewNPC((int)npc.position.X - 0, (int)npc.position.Y - 5, ModContent.NPCType<EnforcerAssister>());
                NPC.NewNPC((int)npc.position.X - 0, (int)npc.position.Y - 0, ModContent.NPCType<EnforcerAssister>());
                phase = 3;
            }
            if (npc.life < npc.lifeMax * .4 && phase == 3)
            {
                NPC.NewNPC((int)npc.position.X - 5, (int)npc.position.Y, ModContent.NPCType<EnforcerAssister>());
                NPC.NewNPC((int)npc.position.X - 0, (int)npc.position.Y, ModContent.NPCType<EnforcerAssister>());
                NPC.NewNPC((int)npc.position.X - 0, (int)npc.position.Y - 5, ModContent.NPCType<EnforcerAssister>());
                NPC.NewNPC((int)npc.position.X - 5, (int)npc.position.Y - 5, ModContent.NPCType<EnforcerAssister>());
                phase = 4;
            }
            if (npc.life < npc.lifeMax * .2 && phase == 4 && Main.expertMode)
            {
                NPC.NewNPC((int)npc.position.X - 5, (int)npc.position.Y, ModContent.NPCType<EnforcerAssister>());
                NPC.NewNPC((int)npc.position.X - 5, (int)npc.position.Y - 5, ModContent.NPCType<EnforcerAssister>());
                NPC.NewNPC((int)npc.position.X - 10, (int)npc.position.Y - 10, ModContent.NPCType<EnforcerAssister>());
                NPC.NewNPC((int)npc.position.X - 10, (int)npc.position.Y, ModContent.NPCType<EnforcerAssister>());
                NPC.NewNPC((int)npc.position.X - 0, (int)npc.position.Y - 5, ModContent.NPCType<EnforcerAssister>());
                NPC.NewNPC((int)npc.position.X - 0, (int)npc.position.Y - 10, ModContent.NPCType<EnforcerAssister>());
                NPC.NewNPC((int)npc.position.X - 0, (int)npc.position.Y, ModContent.NPCType<EnforcerAssister>());
                NPC.NewNPC((int)npc.position.X - 0, (int)npc.position.Y, ModContent.NPCType<EnforcerAssister>());
                phase = 5;
            }
        }


            public override void BossLoot(ref string name, ref int potionType)
            {
                if (OurStuffAddonWorld.downedLifeEnforcer)
                {
                    Main.NewText("I could not stop it...", 250, 200, 200);
                }

                if (OurStuffAddonWorld.heartStone == false)
                {
                    OurStuffAddonWorld.heartStone = true;
                    Main.NewText("Life bursts through the world", 250, 200, 200);
                }
            }

        /*private void GenerateHeartStone()
        {
            int sizeMult = (int)(Math.Floor(Main.maxTilesX / 4200f));
            for (int i = 0; i < 30 * sizeMult; i++)
            {
                HeartStone.StructureGenBig(Main.rand.Next(200, Main.maxTilesX - 200), Main.rand.Next(350 * sizeMult, Main.maxTilesY - 400));
            }
            for (int i = 0; i < 100 * sizeMult; i++)
            {
                HeartStone.StructureGenMed(Main.rand.Next(200, Main.maxTilesX - 200), Main.rand.Next(350 * sizeMult, Main.maxTilesY - 400));
            }
            for (int i = 0; i < 120 * sizeMult; i++)
            {
                HeartStone.StructureGenSmall(Main.rand.Next(200, Main.maxTilesX - 200), Main.rand.Next(350 * sizeMult, Main.maxTilesY - 400));
            }
        }*/
    }
}