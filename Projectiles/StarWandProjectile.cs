using System;
using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Projectiles
{
	public class StarWandProjectile : ModProjectile
	{
		public override void SetDefaults()
		{
			//projectile.name = "StarWandProjectile";
			projectile.width = 5;
			projectile.height = 5;
			projectile.friendly = true;
			projectile.penetrate = 3;                       //this is the projectile penetration
			Main.projFrames[projectile.type] = 1;           //this is projectile frames
			projectile.hostile = false;
			projectile.magic = true;                        //this make the projectile do magic damage
			projectile.tileCollide = true;                 //this make that the projectile does not go thru walls
			projectile.ignoreWater = false;
		}

		public override void AI()
		{
			projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
			projectile.localAI[0] += 1f;
			projectile.alpha = (int)projectile.localAI[0] * 2;

			if (projectile.localAI[0] > 115f) //projectile time left before disappears
			{
				projectile.Kill();
			}
		}
	}
}