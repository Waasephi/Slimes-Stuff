using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Items.Consumables
{
	public class LifeEnforcerTreasureBag : ModItem
	{
		public override int BossBagNPC => ModContent.NPCType<LifeEnforcer>();

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
				player.QuickSpawnItem(ModContent.ItemType<MineralChunk>(), Main.rand.Next(5, 7));
			player.QuickSpawnItem(ModContent.ItemType<HeartOfTheCaverns>(), Main.rand.Next(1, 1));
		}
	}
}