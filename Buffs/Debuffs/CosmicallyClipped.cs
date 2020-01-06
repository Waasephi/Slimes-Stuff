using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Buffs.Debuffs
{
    public class CosmicallyClipped : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Cosmically Clipped");
            Description.SetDefault("You Cannot fly.");
            Main.buffNoTimeDisplay[Type] = true;
            Main.buffNoSave[Type] = true;
            canBeCleared = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            OurStuffAddonPlayer p = player.GetModPlayer<OurStuffAddonPlayer>();
                // Some other effects:
                //player.lifeRegen++;
                //player.meleeCrit += 2;
                player.wingTimeMax = -1;
                //player.meleeSpeed += 0.051f;
                //player.statDefense += 3;
                //player.moveSpeed += 0.05f;

            
        }
    }
}