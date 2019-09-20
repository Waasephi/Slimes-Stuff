using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Projectiles.Pets
{
    public class SpiritPet : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Paper Airplane"); // Automatic from .lang files
            Main.projFrames[projectile.type] = 4;
            Main.projPet[projectile.type] = true;
        }

        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.ZephyrFish);
            aiType = ProjectileID.ZephyrFish;
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
                modPlayer.SpiritPet = false;
            }
            if (modPlayer.SpiritPet)
            {
                projectile.timeLeft = 2;
            }
        }
    }
}