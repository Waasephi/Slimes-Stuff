using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.NPCs.Bosses.NeoMothership
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
        private float speed;
        private Player player;
        int _despawn = 0;
        private int attackTimer = 1;
        private int count = 0;
        private float heightMod = -350f;
        public override void SetDefaults()
        {
            npc.width = 156;
            npc.height = 72;
            npc.damage = 80;
            npc.lifeMax = 5000;
            npc.life = 5000;
            npc.defense = 0;
            _despawn = 0;
            phase = 1;
            npc.HitSound = SoundID.NPCHit4;
            npc.DeathSound = SoundID.NPCDeath14;
            npc.value = 1000f;
            npc.knockBackResist = 0f;
            npc.boss = true;
            Lighting.AddLight(npc.Center, 0f, 2f, 0f);
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
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
            NPC.NewNPC((int)npc.position.X - 50, (int)npc.position.Y, ModContent.NPCType<NeoParasite>());
        }

        public override void AI()
        {

            Player player = Main.player[npc.target];
            if (npc.target < 0 || npc.target == 255 || Main.player[npc.target].dead || !Main.player[npc.target].active)
            {
                npc.TargetClosest(true);
            }
            npc.netUpdate = true;

            //DESPAWN
            if (!Main.player[npc.target].active || Main.player[npc.target].dead)
            {
                npc.TargetClosest(true);
                if (!Main.player[npc.target].active || Main.player[npc.target].dead)
                {
                    if (_despawn == 0)
                        _despawn++;
                }
            }

            float wantedSpeed = 20f;

            Target();
            Move(Vector2.Zero);
            Vector2 shootVelocity = npc.DirectionTo(player.Center) * wantedSpeed;


            attackTimer--;

            if (attackTimer == 0)
            {

                attackTimer = 10;
                if (count == 0)
                {
                    count = 7;
                    Main.PlaySound(2, (int)npc.position.X, (int)npc.position.Y, 12);
                    Projectile.NewProjectile(npc.Center, shootVelocity, mod.ProjectileType("NeonBeam"), 10, 7, Main.LocalPlayer.whoAmI);
                }
                count--;
            }
        }
        private void Move(Vector2 offset)
        {
            speed = 15f;

            Vector2 goalPosition = new Vector2(player.Center.X, player.Center.Y + heightMod);
            Vector2 move = goalPosition - npc.Center;
            float magnitude = Magnitude(move);
            if (magnitude > speed)
            {
                move *= speed / magnitude;
            }
            float turnResistance = 10f;
            move = (npc.velocity * turnResistance + move) / (turnResistance + 1f);
            magnitude = Magnitude(move);
            if (magnitude > speed)
            {
                move *= speed / magnitude;
            }
            npc.velocity = move;
        }
        private float Magnitude(Vector2 mag)
        {
            return (float)Math.Sqrt(mag.X * mag.X + mag.Y * mag.Y);

        }
        private void Target()
        {
            player = Main.player[npc.target];
        }
        int frame = 0;
        public override void FindFrame(int frameHeight)
        {
            npc.frameCounter++;
            if (npc.frameCounter > 4)
            {  //7 frames between each "frame" of animation
                npc.frameCounter = 0;
                frame++;
                if (frame >= Main.npcFrameCount[npc.type])
                {
                    frame = 0;
                }
            }
            npc.frame.Y = frame * frameHeight;
        }
    }
}