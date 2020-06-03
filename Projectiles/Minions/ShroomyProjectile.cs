using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Projectiles.Minions
{
	public class ShroomyProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			Main.projFrames[projectile.type] = 1;
			Main.projPet[projectile.type] = true;
			ProjectileID.Sets.MinionSacrificable[projectile.type] = true;
			ProjectileID.Sets.MinionTargettingFeature[projectile.type] = true; //This is necessary for right-click targeting
		}

		public override void SetDefaults()
		{
			projectile.width = 22;
			projectile.height = 24;
			projectile.netImportant = true;
			projectile.friendly = true;
			projectile.ignoreWater = true;
			projectile.aiStyle = 66;
			projectile.minionSlots = 1f;
			projectile.timeLeft = 18000;
			projectile.penetrate = -1;
			projectile.tileCollide = false;
			projectile.timeLeft *= 5;
			projectile.minion = true;
			aiType = 388;
		}

		/*public override void CheckActive()
        {
            Player player = Main.player[projectile.owner];
            OurStuffAddonPlayer modPlayer = player.GetModPlayer<OurStuffAddonPlayer>();
            if (player.dead)
            {
                modPlayer.ShroomBuff = false;
            }
            if (modPlayer.Shroomy)
            { // Make sure you are resetting this bool in ModPlayer.ResetEffects. See ExamplePlayer.ResetEffects
                projectile.timeLeft = 2;
            }
        }*/

		public override void AI()
		{
			projectile.rotation += projectile.velocity.X * 0.04f;
			bool flag64 = projectile.type == mod.ProjectileType("Shroomy");
			Player player = Main.player[projectile.owner];
			ModPlayer modPlayer = player.GetModPlayer<ModPlayer>();
			player.AddBuff(mod.BuffType("ShroomBuff"), 3600);
			if (flag64)
			{
			}
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			if (projectile.penetrate == 0)
			{
				projectile.Kill();
			}
			return false;
		}
	}
}