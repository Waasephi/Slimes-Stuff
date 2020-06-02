using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Projectiles
{
	public class SeafoamBolt : ModProjectile
	{
		public override void SetDefaults()
		{
			//projectile.name = "StickProjectile";
			projectile.width = 22;
			projectile.height = 22;
			projectile.friendly = true;
			projectile.penetrate = 1;                       //this is the projectile penetration
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
			if (Main.rand.NextBool(3))
			{
				Dust.NewDust(projectile.position + projectile.velocity, projectile.width, projectile.height, mod.DustType("SeafoamDust"), projectile.velocity.X * 0.5f, projectile.velocity.Y * 0.5f);
			}

			if (projectile.localAI[0] > 500f) //projectile time left before disappears
			{
				projectile.Kill();
			}
		}

		public override bool PreDraw(SpriteBatch sb, Color lightColor) //this is where the animation happens
		{
			projectile.frameCounter++; //increase the frameCounter by one
			if (projectile.frameCounter >= 5) //once the frameCounter has reached 10 - change the 10 to change how fast the projectile animates
			{
				projectile.frame++; //go to the next frame
				projectile.frameCounter = 0; //reset the counter
				if (projectile.frame > 5) //if past the last frame
					projectile.frame = 0; //go back to the first frame
			}
			return true;
		}
	}
}