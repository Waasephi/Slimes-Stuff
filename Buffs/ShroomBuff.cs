using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Buffs
{
    public class ShroomBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Shroomy");
            Description.SetDefault("The mushrooms will fight for you");
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            OurStuffAddonPlayer modPlayer = player.GetModPlayer<OurStuffAddonPlayer>();
            if (player.ownedProjectileCounts[mod.ProjectileType("Shroomy")] > 0)
            {
                modPlayer.ShroomBuff = true;
            }
            if (!modPlayer.ShroomBuff)
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