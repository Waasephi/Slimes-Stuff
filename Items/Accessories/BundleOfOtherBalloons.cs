using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Accessories
{
	public class BundleOfOtherBalloons : ModItem //replace ItemName with the name of your accessory
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bundle of Other Balloons");
			Tooltip.SetDefault("Fart in a Bottle effects, Increased Jump Height and No Fall Damage.");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
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
			item.rare = ItemRarityID.Green;
			item.accessory = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SharkronBalloon);
			recipe.AddIngredient(ItemID.FartInABalloon);
			recipe.AddIngredient(ItemID.BalloonHorseshoeHoney);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}