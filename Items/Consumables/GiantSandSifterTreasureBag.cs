using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using OurStuffAddon.Items.Ranged;
using OurStuffAddon.Items.Throwing;
using OurStuffAddon.Items.Magic;
using OurStuffAddon.Items.Melee;
using OurStuffAddon.Items.Accessories;
using OurStuffAddon.Items.Materials;
using OurStuffAddon.NPCs.Bosses;

namespace OurStuffAddon.Items.Consumables
{
	public class GiantSandSifterTreasureBag : ModItem
	{
		public override int BossBagNPC => ModContent.NPCType<GiantSandSifterHead>();

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

				player.QuickSpawnItem(ModContent.ItemType<SandSifterScale>(), Main.rand.Next(10, 15));
			player.QuickSpawnItem(ModContent.ItemType<SandSifterMandible>(), Main.rand.Next(10, 15));
			player.QuickSpawnItem(ModContent.ItemType<GiantSandSifterEye>());
			int loots = Main.rand.Next(5);
			switch (loots)
			{
				case 1:
					player.QuickSpawnItem(ModContent.ItemType<SiftersTooth>(), Main.rand.Next(1, 1));
					break;

				case 2:
					player.QuickSpawnItem(ModContent.ItemType<SandTome>(), Main.rand.Next(1, 1));
					break;

				case 3:
					player.QuickSpawnItem(ModContent.ItemType<DesertDuster>(), Main.rand.Next(1, 1));
					break;

				case 4:
					player.QuickSpawnItem(ModContent.ItemType<DesertFang>(), Main.rand.Next(100, 100));
					break;
			}
		}
	}
}