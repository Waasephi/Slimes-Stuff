using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Consumables
{
	public class MineralChunk : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("MineralChunk");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = ItemRarityID.Cyan;
			item.expert = false;
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
			int loots = Main.rand.Next(18);
			switch (loots)
			{
				case 1:
					player.QuickSpawnItem(mod.ItemType("TrenagonBar"), Main.rand.Next(7, 10));
					break;

				case 2:
					player.QuickSpawnItem(ItemID.CopperBar, Main.rand.Next(7, 10));
					break;

				case 3:
					player.QuickSpawnItem(ItemID.TinBar, Main.rand.Next(7, 10));
					break;

				case 4:
					player.QuickSpawnItem(ItemID.IronBar, Main.rand.Next(7, 10));
					break;

				case 5:
					player.QuickSpawnItem(ItemID.LeadBar, Main.rand.Next(7, 10));
					break;

				case 6:
					player.QuickSpawnItem(ItemID.SilverBar, Main.rand.Next(7, 10));
					break;

				case 7:
					player.QuickSpawnItem(ItemID.TungstenBar, Main.rand.Next(7, 10));
					break;

				case 8:
					player.QuickSpawnItem(ItemID.GoldBar, Main.rand.Next(7, 10));
					break;

				case 9:
					player.QuickSpawnItem(ItemID.PlatinumBar, Main.rand.Next(7, 10));
					break;

				case 10:
					player.QuickSpawnItem(ItemID.Topaz, Main.rand.Next(7, 10));
					break;

				case 11:
					player.QuickSpawnItem(ItemID.Amethyst, Main.rand.Next(7, 10));
					break;

				case 12:
					player.QuickSpawnItem(ItemID.Sapphire, Main.rand.Next(7, 10));
					break;

				case 13:
					player.QuickSpawnItem(ItemID.Emerald, Main.rand.Next(7, 10));
					break;

				case 14:
					player.QuickSpawnItem(ItemID.Ruby, Main.rand.Next(7, 10));
					break;

				case 15:
					player.QuickSpawnItem(ItemID.Diamond, Main.rand.Next(7, 10));
					break;

				case 16:
					player.QuickSpawnItem(mod.ItemType("ShadowCrystal"), Main.rand.Next(7, 10));
					break;

				case 17:
					player.QuickSpawnItem(mod.ItemType("SeafoamCrystal"), Main.rand.Next(7, 10));
					break;
			}
		}
	}
}