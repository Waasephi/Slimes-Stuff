using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Projectiles
{
    public class CosmicLaser : ModProjectile
    {
        public int grounded = 0;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("CosmicLaser");
            //ProjectileID.Sets.Homing[projectile.type] = true;
            //ProjectileID.Sets.MinionShot[projectile.type] = true;
        }

        public override void SetDefaults()
        {
            grounded = 0;
            projectile.width = 2;
            projectile.height = 42;
            //projectile.alpha = 255;
            projectile.timeLeft = 300;
            projectile.friendly = false;
            projectile.hostile = true;
            projectile.ignoreWater = true;
            projectile.tileCollide = false;
        }

        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + .785f;

        }

    }
}