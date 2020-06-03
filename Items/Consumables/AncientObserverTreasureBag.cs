using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using OurStuffAddon.NPCs.Bosses.AncientObserver;
using OurStuffAddon.Items.Materials;
using OurStuffAddon.Items.Accessories;

namespace OurStuffAddon.Items.Consumables
{
	public class AncientObserverTreasureBag : ModItem
	{
		public override int BossBagNPC => ModContent.NPCType<AncientObserver>();

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Observer Treasure Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = ItemRarityID.Cyan;
			item.expert = true;
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void OpenBossBag(Player player)
		{
			if (Main.rand.Next(0) == 0)
				player.QuickSpawnItem(ModContent.ItemType<RelicShard>(), Main.rand.Next(3, 5));
			player.QuickSpawnItem(ModContent.ItemType<ChippedStone>(), Main.rand.Next(12, 24));
			player.QuickSpawnItem(ModContent.ItemType<AncientPebble>(), Main.rand.Next(1, 1));
		}
	}
}