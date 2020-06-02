using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Consumables
{
    public class NeoParasiteTreasureBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Neo Parasite Treasure Bag");
            Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}(2 Expert Items, Both Ranged)");
        }

        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.consumable = true;
            item.width = 24;
            item.height = 24;
            item.rare = 9;
            item.expert = true;

        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {

            if (Main.rand.Next(0) == 0)
                player.QuickSpawnItem(mod.ItemType("NeoPickaxe"));
            player.QuickSpawnItem(mod.ItemType("NeoniumBar"), Main.rand.Next(10, 15));
            int loots = Main.rand.Next(2);
            switch (loots)
            {
                case 1:
                    player.QuickSpawnItem(mod.ItemType("NeoEnergyPouch"), Main.rand.Next(1, 1));
                    break;
                case 2:
                    player.QuickSpawnItem(mod.ItemType("NeoQuiver"), Main.rand.Next(1, 1));
                    break;
            }

        }
        public override int BossBagNPC => mod.NPCType("NeoParasite");
    }
}