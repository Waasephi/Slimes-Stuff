using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Projectiles
{
	public class HolyDaggerProjectile : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 12;
			projectile.height = 12;
			projectile.friendly = true;
			projectile.aiStyle = 1;
			projectile.thrown = true;
			projectile.penetrate = 5;      //this is how many enemy this projectile penetrate before disappear
			projectile.extraUpdates = 1;
			aiType = 507;
			Main.projFrames[projectile.type] = 1;
			projectile.tileCollide = true;
			projectile.ignoreWater = false;
		}

		public override void AI()
		{
			projectile.rotation = (float)Math.Atan2(projectile.velocity.Y, projectile.velocity.X) + 1.57f;
			projectile.localAI[0] += 1f;
			projectile.ai[0] += 1f;
			if (projectile.ai[0] >= 100000f)       //how much time the projectile can travel before landing
			{
				projectile.velocity.X = projectile.velocity.X * 1.5f;    // projectile velocity
				projectile.Kill();
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