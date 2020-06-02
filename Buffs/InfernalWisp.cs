using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace OurStuffAddon.Buffs
{
    public class InfernalWisp : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Infernal Wisp");
            Description.SetDefault("An infernal wisp will fight for you");
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            OurStuffAddonPlayer modPlayer = player.GetModPlayer<OurStuffAddonPlayer>();
            if (player.ownedProjectileCounts[ProjectileType<Projectiles.Minions.InfernalWisp>()] > 0)
            {
                modPlayer.InfernalWisp = true;
            }
            if (!modPlayer.InfernalWisp)
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