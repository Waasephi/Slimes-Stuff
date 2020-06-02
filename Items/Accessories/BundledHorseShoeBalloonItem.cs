using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Items.Accessories
{
	[AutoloadEquip(EquipType.Balloon)]
	public class BundledHorseShoeBalloonItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bundled Horseshoe Balloon");
			Tooltip.SetDefault("Bundle of balloons and horseshoe effects.");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.doubleJumpCloud = true;
			player.doubleJumpBlizzard = true;
			player.doubleJumpSandstorm = true;
			player.jumpBoost = true;
			player.noFallDmg = true;
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.accessory = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BundleofBalloons, 1);
			recipe.AddIngredient(ItemID.LuckyHorseshoe, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}