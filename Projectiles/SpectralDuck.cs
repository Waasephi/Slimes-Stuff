using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Projectiles
{
	public class SpectralDuck : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			ProjectileID.Sets.Homing[projectile.type] = true;
		}

		public override void SetDefaults()
		{
			projectile.width = 22;
			projectile.height = 22;
			projectile.friendly = true;
			projectile.aiStyle = 0;
			projectile.thrown = true;
			projectile.penetrate = 1;      //this is how many enemy this projectile penetrate before disappear
			projectile.extraUpdates = 1;
			Main.projFrames[projectile.type] = 4;
			aiType = 507;
			projectile.tileCollide = true;
			projectile.ignoreWater = false;
		}

		public override void AI()
		{
			projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
			if (projectile.localAI[0] == 0f)
			{
				Main.PlaySound(SoundID.Item20, projectile.position);
				projectile.localAI[0] = 1f;
			}
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.BrokenArmor, 180);
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{                                                           // sound that the projectile make when hitting the terrain
			{
				projectile.Kill();

				Main.PlaySound(30, (int)projectile.position.X, (int)projectile.position.Y, 1);
			}
			return false;
		}

		public override bool PreDraw(SpriteBatch sb, Color lightColor) //this is where the animation happens
		{
			projectile.frameCounter++; //increase the frameCounter by one
			if (projectile.frameCounter >= 4) //once the frameCounter has reached 10 - change the 10 to change how fast the projectile animates
			{
				projectile.frame++; //go to the next frame
				projectile.frameCounter = 0; //reset the counter
				if (projectile.frame >= 4) //if past the last frame
					projectile.frame = 0; //go back to the first frame
			}
			return true;
		}
	}
}