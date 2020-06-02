using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace OurStuffAddon.Buffs
{
    public class TrueSpiritWisp : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("True Spirit Wisp");
            Description.SetDefault("A true spirit wisp will fight for you");
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            OurStuffAddonPlayer modPlayer = player.GetModPlayer<OurStuffAddonPlayer>();
            if (player.ownedProjectileCounts[ProjectileType<Projectiles.Minions.TrueSpiritWisp>()] > 0)
            {
                modPlayer.TrueSpiritWisp = true;
            }
            if (!modPlayer.TrueSpiritWisp)
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