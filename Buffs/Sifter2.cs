using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using OurStuffAddon.Projectiles.Minions;

namespace OurStuffAddon.Buffs
{
    public class Sifter2 : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Sifter");
            Description.SetDefault("A Sand Sifter Head will fight for you");
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            if (player.whoAmI == Main.myPlayer && player.ownedProjectileCounts[mod.ProjectileType("SifterProjectile2")] < 1)
                Projectile.NewProjectile(player.Center, Vector2.Zero, mod.ProjectileType("SifterProjectile2"), 0, 0f, player.whoAmI);
            else
            {
                player.DelBuff(buffIndex);
                buffIndex--;
            }
        }
    }
}