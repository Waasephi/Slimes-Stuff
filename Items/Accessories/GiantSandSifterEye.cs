using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Accessories
{
    public class GiantSandSifterEye : ModItem //replace ItemName with the name of your accessory
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sand Sifter Eye");
            Tooltip.SetDefault("Wait... They have eyes? (+1 minion and gives 3 defence)");
        }
        public override void UpdateAccessory(Player player, bool hideVisual) //Where it says "p" is the variable used to represent "player". In this case, every p stands for player. This is called when the accessory is on.
        {
            player.magmaStone = true;
            player.statDefense += 3;
        }
        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 20;
            item.value = 10000;
            item.rare = 2;
            item.accessory = true;
            item.expert = true;
        }
    }

}
