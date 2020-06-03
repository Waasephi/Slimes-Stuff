using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using OurStuffAddon.Items.Accessories;
using OurStuffAddon.Items.Materials;
using OurStuffAddon.NPCs.Bosses;

namespace OurStuffAddon.Items.Consumables
{
	public class CosmicSlimeTreasureBag : ModItem
	{
		public override int BossBagNPC => ModContent.NPCType<CosmicSlime>();

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cosmic Slime Treasure Bag");
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
				player.QuickSpawnItem(ModContent.ItemType<CosmicJelly>(), Main.rand.Next(30, 45));

			player.QuickSpawnItem(ModContent.ItemType<CosmicFragment>(), Main.rand.Next(10, 15));
			player.QuickSpawnItem(3458, Main.rand.Next(10, 15));
			player.QuickSpawnItem(3456, Main.rand.Next(10, 15));
			player.QuickSpawnItem(3457, Main.rand.Next(10, 15));
			player.QuickSpawnItem(3459, Main.rand.Next(10, 15));
			player.QuickSpawnItem(ModContent.ItemType<CosmicCore>(), Main.rand.Next(1, 1));
		}
	}
}