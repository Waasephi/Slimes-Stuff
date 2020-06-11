using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Projectiles
{
	public class SpiritArrowProjectile : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 8;
			projectile.height = 8;
			projectile.friendly = true;
			projectile.penetrate = 3;                       //this is the projectile penetration
			Main.projFrames[projectile.type] = 1;           //this is projectile frames
			projectile.hostile = false;
			projectile.ranged = true;
			projectile.aiStyle = 1;
			projectile.tileCollide = true;                 //this make that the projectile does not go thru walls
			projectile.ignoreWater = false;
		}
	}
}