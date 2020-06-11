using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using OurStuffAddon.Items.Tools;
using OurStuffAddon.Items.Materials;
using OurStuffAddon.Items.Ranged.Ammo;
using OurStuffAddon.NPCs.Bosses;

namespace OurStuffAddon.Items.Consumables
{
	public class NeoParasiteTreasureBag : ModItem
	{
		public override int BossBagNPC => ModContent.NPCType<NeoParasite>();

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Neo Parasite Treasure Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}(2 Expert Items, Both Ranged, Not Guaranteed)");
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
				player.QuickSpawnItem(ModContent.ItemType<NeoPickaxe>());
			player.QuickSpawnItem(ModContent.ItemType<NeoniumBar>(), Main.rand.Next(10, 15));
			int loots = Main.rand.Next(5);
			switch (loots)
			{
				case 1:
					player.QuickSpawnItem(ModContent.ItemType<NeoEnergyPouch>(), Main.rand.Next(1, 1));
					break;

				case 2:
					player.QuickSpawnItem(ModContent.ItemType<NeoQuiver>(), Main.rand.Next(1, 1));
					break;
			}
		}
	}
}