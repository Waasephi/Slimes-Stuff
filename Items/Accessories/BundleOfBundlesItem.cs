using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Accessories
{
	public class BundleOfBundlesItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bundle Of Bundles");
			Tooltip.SetDefault("Okay This Is A Bit Excessive, Effects of All of the Balloons.");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.doubleJumpCloud = true;
			player.doubleJumpBlizzard = true;
			player.doubleJumpSandstorm = true;
			player.doubleJumpFart = true;
			//player.doubleJump5 = true;
			player.jumpBoost = true;
			player.noFallDmg = true;
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 10000;
			item.rare = ItemRarityID.Pink;
			item.accessory = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BundledHorseShoeBalloon");
			recipe.AddIngredient(mod, "BundleOfOtherBalloons");
			recipe.AddIngredient(ItemID.PartyBundleOfBalloonsAccessory);
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}