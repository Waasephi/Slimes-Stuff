using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Projectiles.Minions
{
	//ported from my tAPI mod because I'm lazy
	public class BlueSlime : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			Main.projFrames[projectile.type] = 5;
			Main.projPet[projectile.type] = true;
			ProjectileID.Sets.MinionSacrificable[projectile.type] = true;
			ProjectileID.Sets.MinionTargettingFeature[projectile.type] = true; //This is necessary for right-click targeting
		}

		public override void SetDefaults()
		{
			projectile.netImportant = true;
			projectile.width = 24;
			projectile.height = 32;
			projectile.friendly = true;
			projectile.aiStyle = 26;
			projectile.minion = true;
			projectile.minionSlots = 1;
			projectile.penetrate = -1;
			projectile.timeLeft = 18000;
			projectile.tileCollide = false;
			projectile.ignoreWater = true;
		}

		/* public override void CheckActive()
         {
             Player player = Main.player[projectile.owner];
             OurStuffAddonPlayer modPlayer = player.GetModPlayer<OurStuffAddonPlayer>();
             if (player.dead)
             {
                 modPlayer.blueSlime = false;
             }
             if (modPlayer.blueSlime)
             { // Make sure you are resetting this bool in ModPlayer.ResetEffects. See ExamplePlayer.ResetEffects
                 projectile.timeLeft = 2;
             }*/
	}
}