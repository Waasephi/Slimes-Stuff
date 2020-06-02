using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using OurStuffAddon.Projectiles.Minions;

namespace OurStuffAddon.Buffs
{
    public class Sifter : ModBuff
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
            if (player.ownedProjectileCounts[ProjectileType<SifterProjectile>()] > 0)
            {
                player.buffTime[buffIndex] = 18000;
            }
            else
            {
                player.DelBuff(buffIndex);
                buffIndex--;
            }
        }
    }
}