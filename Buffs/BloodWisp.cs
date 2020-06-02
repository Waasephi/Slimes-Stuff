using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace OurStuffAddon.Buffs
{
    public class BloodWisp : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Blood Wisp");
            Description.SetDefault("A blood wisp will fight for you");
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            OurStuffAddonPlayer modPlayer = player.GetModPlayer<OurStuffAddonPlayer>();
            if (player.ownedProjectileCounts[ProjectileType<Projectiles.Minions.BloodWisp>()] > 0)
            {
                modPlayer.BloodWisp = true;
            }
            if (!modPlayer.BloodWisp)
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