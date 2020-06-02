using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Items.Accessories
{
	public class DashCharm : ModItem //replace ItemName with the name of your accessory
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dash Charm");
			Tooltip.SetDefault("Harness the power of the shadows and push yourself forward.");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.dash = 2;
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.accessory = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ShadowCrystal", 50);
			recipe.AddIngredient(ItemID.NinjaHood, 1);
			recipe.AddIngredient(257, 1);
			recipe.AddIngredient(258, 1);
			recipe.AddTile(114);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}