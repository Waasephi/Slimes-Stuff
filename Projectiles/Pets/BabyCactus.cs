using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Projectiles.Pets
{
    public class BabyCactus : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Paper Airplane"); // Automatic from .lang files
            Main.projFrames[projectile.type] = 8;
            Main.projPet[projectile.type] = true;
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.Bunny);
            aiType = ProjectileID.Bunny;
        }

        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.bunny = false; // Relic from aiType
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            OurStuffAddonPlayer modPlayer = player.GetModPlayer<OurStuffAddonPlayer>();
            if (player.dead)
            {
                modPlayer.BabyCactus = false;
            }
            if (modPlayer.BabyCactus)
            {
                projectile.timeLeft = 2;
            }
        }
    }
}