using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace OurStuffAddon.Buffs
{
    public class ChloroBulb : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Chlorophyte Bulb");
            Description.SetDefault("A Chlorophyte Bulb will fight for you");
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            OurStuffAddonPlayer modPlayer = player.GetModPlayer<OurStuffAddonPlayer>();
            if (player.ownedProjectileCounts[ProjectileType<Projectiles.Minions.ChloroBulb>()] > 0)
            {
                modPlayer.ChloroBulb = true;
            }
            if (!modPlayer.ChloroBulb)
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