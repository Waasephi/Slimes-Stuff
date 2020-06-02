using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace OurStuffAddon.Buffs
{
    public class StardustWisp : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Stardust Wisp");
            Description.SetDefault("A Stardust wisp will fight for you");
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            OurStuffAddonPlayer modPlayer = player.GetModPlayer<OurStuffAddonPlayer>();
            if (player.ownedProjectileCounts[ProjectileType<Projectiles.Minions.StardustWisp>()] > 0)
            {
                modPlayer.StardustWisp = true;
            }
            if (!modPlayer.StardustWisp)
            {
                player.DelBuff(buffIndex);
                buffIndex--;
            }
            else
            {
                player.buffTime[buffIndex] = 18000;
            }
        }
    }
}