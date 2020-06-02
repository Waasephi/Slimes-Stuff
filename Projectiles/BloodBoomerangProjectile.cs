using Terraria.ModLoader;

namespace OurStuffAddon.Projectiles
{
	public class BloodBoomerangProjectile : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 24;
			projectile.height = 40;
			projectile.aiStyle = 3;
			projectile.friendly = true;
			projectile.thrown = true;
			projectile.magic = false;
			projectile.penetrate = 5;
			projectile.timeLeft = 600;
			projectile.light = 0.5f;
			projectile.extraUpdates = 1;
		}
	}
}