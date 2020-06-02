using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace OurStuffAddon.Buffs
{
    public class CursedWisp : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Cursed Wisp");
            Description.SetDefault("A cursed wisp will fight for you");
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            OurStuffAddonPlayer modPlayer = player.GetModPlayer<OurStuffAddonPlayer>();
            if (player.ownedProjectileCounts[ProjectileType<Projectiles.Minions.CursedWisp>()] > 0)
            {
                modPlayer.CursedWisp = true;
            }
            if (!modPlayer.CursedWisp)
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