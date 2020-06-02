using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Accessories
{
	[AutoloadEquip(EquipType.Balloon)]
	public class BundledHorseShoeBalloon : ModItem //replace ItemName with the name of your accessory
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
			item.rare = 2;
			item.accessory = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1164, 1);
			recipe.AddIngredient(158, 1);
			recipe.AddTile(114);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}