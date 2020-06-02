using Terraria;
using Terraria.ModLoader;
using OurStuffAddon.Items.SpiritDamageClass;
using Terraria.ID;

namespace OurStuffAddon.Buffs
{
    public class SpiritDamage : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Spirit Damage");
            Description.SetDefault("Spirit Damage is increased");
            Main.buffNoTimeDisplay[Type] = false;
            Main.buffNoSave[Type] = true;
            canBeCleared = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            OurStuffAddonPlayer p = player.GetModPlayer<OurStuffAddonPlayer>();
            SpiritDamagePlayer modPlayer = SpiritDamagePlayer.ModPlayer(player);
            modPlayer.spiritDamageMult *= 1.1f;
        }
    }
}