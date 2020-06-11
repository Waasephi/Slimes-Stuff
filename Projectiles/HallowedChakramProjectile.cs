using Terraria.ModLoader;

namespace OurStuffAddon.Projectiles
{
	public class HallowedChakramProjectile : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 3;
			projectile.friendly = true;
			projectile.thrown = true;
			projectile.magic = false;
			projectile.penetrate = 3;
			projectile.timeLeft = 600;
			projectile.light = 0.5f;
			projectile.extraUpdates = 1;
		}
	}
}