using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Consumables
{
    public class LifeEnforcerTreasureBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Life Enforcer Treasure Bag");
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
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {

            if (Main.rand.Next(0) == 0)
                player.QuickSpawnItem(mod.ItemType("MineralChunk"), Main.rand.Next(5, 7));
                player.QuickSpawnItem(mod.ItemType("HeartOfTheCaverns"), Main.rand.Next(1, 1));
        }
        public override int BossBagNPC => mod.NPCType("LifeEnforcer");
    }
}