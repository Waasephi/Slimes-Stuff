using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.NPCs.Bosses.AncientObserver
{
    public class AncientPebbleShot : ModProjectile
    {

        public override void SetDefaults()
        {
            projectile.width = 20;
            projectile.height = 26;
            projectile.friendly = false;
            projectile.hostile = true;
            projectile.damage = 5;
            projectile.aiStyle = 0;
            projectile.thrown = true;
            projectile.penetrate = 1;      //this is how many enemy this projectile penetrate before disappear
            projectile.extraUpdates = 1;
            aiType = 507;
            Main.projFrames[projectile.type] = 1;
            projectile.tileCollide = false;
            projectile.ignoreWater = false;
        }

        public override void AI()
        {
            projectile.ai[0] += 1f;
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
            projectile.localAI[0] += 1f;
            if (projectile.ai[0] >= 300f)       //how much time the projectile can travel before landing
            {
                projectile.velocity.X = projectile.velocity.X * 1.5f;    // projectile velocity
                projectile.Kill();
            }
            {
                projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
                if (projectile.localAI[0] == 0f)
                {
                    Main.PlaySound(SoundID.Item20, projectile.position);
                    projectile.localAI[0] = 1f;
                }
                int dust = Dust.NewDust(projectile.position, projectile.width, projectile.height, 66, 0f, 0f, 100, new Color(140, 150, 140), 1f);
                Main.dust[dust].velocity *= 0.1f;
                if (projectile.velocity == Vector2.Zero)
                {
                    Main.dust[dust].velocity.Y -= 1f;
                    Main.dust[dust].scale = 1.2f;
                }
                else
                {
                    Main.dust[dust].velocity += projectile.velocity * 0.2f;
                }
                Main.dust[dust].position.X = projectile.Center.X + 4f + (float)Main.rand.Next(-2, 3);
                Main.dust[dust].position.Y = projectile.Center.Y + (float)Main.rand.Next(-2, 3);
                Main.dust[dust].noGravity = true;
            }
        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {                                                           // sound that the projectile make when hitting the terrain
            {
                projectile.Kill();

                Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 10);
            }
            return false;
        }
    }
}