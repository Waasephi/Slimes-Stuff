using System;
using Terraria.ModLoader;

namespace OurStuffAddon.Projectiles
{
	public class CosmicLaserProjectile : ModProjectile
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
			projectile.rotation = (float)Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + .785f;
		}
	}
}
