using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Consumables
{
    public class GiantSandSifterTreasureBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Giant Sand Sifter Treasure Bag");
            Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
        }

        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.consumable = true;
            item.width = 24;
            item.height = 24;
            item.rare = 9;
            item.expert = true;
            bossBagNPC = mod.NPCType("GiantSandSifterHead");
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {

            if (Main.rand.Next(0) == 0)

            player.QuickSpawnItem(mod.ItemType("SandSifterScale"), Main.rand.Next(3, 5));
            player.QuickSpawnItem(mod.ItemType("SandSifterMandible"), Main.rand.Next(3, 5));
            player.QuickSpawnItem(mod.ItemType("GiantSandSifterEye"));
        }
    }
}