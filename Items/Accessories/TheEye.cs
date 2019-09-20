using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Accessories
{
    public class TheEye : ModItem //replace ItemName with the name of your accessory
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("The Eye");
            Tooltip.SetDefault("(Gives good sight, and Increased Damage)" +
                " [c/debe00:Rare Accessory!]");
        }
        public override void UpdateAccessory(Player player, bool hideVisual) //Where it says "p" is the variable used to represent "player". In this case, every p stands for player. This is called when the accessory is on.
        {

            player.allDamage += 0.3f;
            player.detectCreature = true;
            player.dangerSense = true;
            player.findTreasure = true;
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
