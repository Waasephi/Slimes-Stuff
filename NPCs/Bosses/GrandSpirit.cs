using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.NPCs.Bosses
{
    [AutoloadBossHead]
    public class GrandSpirit : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Grand Spirit, The Broken Spectre");
            Main.npcFrameCount[npc.type] = 14;

        }
        public int phase = 0;
        bool _attacking = false;
        bool _attack = false;
        Vector2 _targetPos;
        public float tVel = 0f;
        public float vMax = 14f;
        public float vAccel = .2f;
        public float vMag = 0f;
        int _attackDelay = 0;
        public override void SetDefaults()
        {
            _attackDelay = 0;
            vMag = 0f;
            vMax = 2f;
            tVel = 0f;
            _targetPos = npc.position;
            _attack = false;
            _attacking = false;
            npc.width = 100;
            npc.height = 100;
            npc.damage = 80;
            npc.lifeMax = 200000;
            npc.life = 200000;
            npc.defense = 0;
            phase = 1;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 1000000f;
            npc.knockBackResist = 0f;
            npc.aiStyle = 0;
            npc.boss = true;
            Lighting.AddLight(npc.Center, 4f, 2f, 0f);
            music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/CosmicSlimeTheme");
            bossBag = mod.ItemType("CosmicSlimeTreasureBag");
        }
        public override void NPCLoot()
        {
            if (!Main.expertMode)
            {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CosmicFragment"), Main.rand.Next(10, 15));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("CosmicJelly"), Main.rand.Next(30, 45));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, (3458), Main.rand.Next(10, 15));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, (3456), Main.rand.Next(10, 15));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, (3457), Main.rand.Next(10, 15));
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, (3459), Main.rand.Next(10, 15));
            }


            /* {
                 int loots2 = Main.rand.Next(10);
                 switch (loots2)
                 {
                     case 1: Item.NewItem(npc.getRect(), mod.ItemType("GiantSandSifterTrophy"), 1); break;
                     case 2: break;
                 }
             }*/
            OurStuffAddonWorld.downedCosmicSlime = true;
            if (Main.expertMode)
            {
                npc.DropBossBags();
            }
        }
        public override bool PreAI()
        {
            npc.TargetClosest(true);
            return true;
        }
        public override void BossLoot(ref string name, ref int potionType)
        {
            potionType = 188;
        }

        public override void AI()
        {
            //Attack
            if (_attack)
            {
                if (Main.netMode != 1)
                {
                    _attack = false;
                    for (int i = 0; i < 8; i++)
                    {
                        int n = NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, mod.NPCType("TitanBlast"));
                        Main.npc[n].ai[0] = npc.whoAmI;
                        Main.npc[n].ai[1] = i;
                    }
                    Main.PlaySound(2, (int)npc.position.X, (int)npc.position.Y, 122);
                }
            }
            if (!_attacking)
                _attackDelay++;
            if (_attackDelay > 60 * 4)
            {
                _attackDelay = 0;
                _attacking = true;
            }

            //Movement
            _targetPos = Main.player[npc.target].Center;
            if (!_attacking)
            {
                float dist = Vector2.Distance(_targetPos, npc.Center);
                tVel = dist / 15;
                if (vMag < vMax && vMag < tVel)
                {
                    vMag += vAccel;
                    vMag = tVel;
                }

                if (vMag > tVel)
                {
                    vMag = tVel;
                }

                if (vMag > vMax)
                {
                    vMag = vMax;
                }

                if (dist != 0)
                {
                    npc.velocity = npc.DirectionTo(_targetPos) * vMag;
                }
            }
            else
            {
                npc.velocity.X *= 3f;
                npc.velocity.Y *= 3f;
            }
        }

        public override void FindFrame(int frameHeight)
        {
            npc.frameCounter += 1;
            if (!_attacking)
            {
                if (npc.frameCounter > 30)
                {
                    npc.frame.Y = npc.frame.Y + frameHeight;
                    npc.frameCounter = 0;
                }
                if (npc.frame.Y > frameHeight * 3)
                {
                    npc.frame.Y = 0;
                }
            }
            else
            {
                if (npc.frame.Y < frameHeight * 4)
                {
                    npc.frame.Y = frameHeight * 4;
                }
                if (npc.frameCounter > 4)
                {
                    if (npc.frame.Y > frameHeight * 10 && npc.frame.Y < frameHeight * 12)
                        _attack = true;
                    npc.frame.Y = npc.frame.Y + frameHeight;
                    npc.frameCounter = 0;
                }
                if (npc.frame.Y > frameHeight * 13)
                {
                    npc.frame.Y = 0;
                    _attacking = false;
                }
            }
        }
    }
}