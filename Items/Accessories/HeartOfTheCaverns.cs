using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Accessories
{
    public class HeartOfTheCaverns : ModItem //replace ItemName with the name of your accessory
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Heart Of The Caverns");
            Tooltip.SetDefault("+40 Max Life");
        }
        public override void UpdateAccessory(Player player, bool hideVisual) //Where it says "p" is the variable used to represent "player". In this case, every p stands for player. This is called when the accessory is on.
        {
            player.statLifeMax2 += 40; //This is where an effect from the list goes.
        }
        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 60;
            item.value = 10000;
            item.rare = 2;
            item.accessory = true;
            item.expert = true;
        }
    }
}
