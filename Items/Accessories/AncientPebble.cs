using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Accessories
{
    public class AncientPebble : ModItem //replace ItemName with the name of your accessory
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ancient Pebble");
            Tooltip.SetDefault("It Shouldn't Be As Useful As It Is... (+7% To All Damage)");
        }
        public override void UpdateAccessory(Player player, bool hideVisual) //Where it says "p" is the variable used to represent "player". In this case, every p stands for player. This is called when the accessory is on.
        {

            player.allDamage *= 1.07f;
        }
        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 20;
            item.value = 10000;
            item.rare = -1;
            item.accessory = true;
            item.expert = true;
        }
    }

}
