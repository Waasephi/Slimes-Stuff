using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.NPCs.Bosses.LifeEnforcer
{
    public class LifeBlast : ModProjectile
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
            aiType = 507;
            Main.projFrames[projectile.type] = 1;
            projectile.tileCollide = false;
            projectile.ignoreWater = false;
        }

        public override void AI()
        {
            projectile.ai[0] += 1f;
            projectile.rotation = projectile.velocity.ToRotation() + MathHelper.PiOver2;
            projectile.localAI[0] += 1f;
            if (projectile.ai[0] >= 300f)       //how much time the projectile can travel before landing
            {
                projectile.velocity.X = projectile.velocity.X * 1f;    // projectile velocity
                projectile.Kill();
            }
            {
                projectile.rotation = projectile.velocity.ToRotation() + MathHelper.PiOver2;
                if (projectile.localAI[0] == 0f)
                {
                    Main.PlaySound(SoundID.Item20, projectile.position);
                    projectile.localAI[0] = 1f;
                }
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

//this is how to make a vanilla enemy projectile a friendly useable one
/*
int proj = Projectile.NewProjectile( whatever you use here to spawn the projectile );
Main.projectile[proj].friendly = true;
Main.projectile[proj].hostile = false;
*/