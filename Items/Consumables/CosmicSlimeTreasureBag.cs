using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Consumables
{
	public class CosmicSlimeTreasureBag : ModItem
	{
		public override int BossBagNPC => mod.NPCType("CosmicSlime");

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
				player.QuickSpawnItem(mod.ItemType("CosmicJelly"), Main.rand.Next(30, 45));
			player.QuickSpawnItem(mod.ItemType("CosmicFragment"), Main.rand.Next(10, 15));
			player.QuickSpawnItem((3458), Main.rand.Next(10, 15));
			player.QuickSpawnItem((3456), Main.rand.Next(10, 15));
			player.QuickSpawnItem((3457), Main.rand.Next(10, 15));
			player.QuickSpawnItem((3459), Main.rand.Next(10, 15));
			player.QuickSpawnItem(mod.ItemType("CosmicCore"), Main.rand.Next(1, 1));
		}
	}
}