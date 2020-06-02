using System;
using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Projectiles
{
	public class NeonBullet : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 8;
			projectile.height = 8;
			projectile.friendly = true;
			projectile.penetrate = 1;                       //this is the projectile penetration
			Main.projFrames[projectile.type] = 1;           //this is projectile frames
			projectile.hostile = false;
			projectile.ranged = true;
			projectile.tileCollide = true;                 //this make that the projectile does not go thru walls
			projectile.ignoreWater = false;
		}

		public override void AI()
		{
			//this is projectile dust
			//int DustID2 = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y + 2f), projectile.width + 9, projectile.height + 9, mod.DustType("DustName"), projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 20, default(Color), 2.9f);
			//Main.dust[DustID2].noGravity = true;
			//this make that the projectile faces the right way
			projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
			projectile.localAI[0] += 1f;
			projectile.alpha = (int)projectile.localAI[0] * 2;
			Lighting.AddLight(projectile.position, 0f, 2f, 0f);

			if (projectile.localAI[0] > 330f) //projectile time left before disappears
			{
				projectile.Kill();
			}
		}
	}
}