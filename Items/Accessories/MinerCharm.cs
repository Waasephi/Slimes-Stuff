using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Accessories
{
	public class MinerCharm : ModItem //replace ItemName with the name of your accessory
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Miner Charm");
			Tooltip.SetDefault("Harness the power of the Sight and push your Mining Prowess beyond (Increases Pick Speed And Gives Great Sight).");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.pickSpeed -= .3f;
			player.detectCreature = true;
			player.dangerSense = true;
			player.findTreasure = true;
			Lighting.AddLight((int)(player.position.X + player.width / 2) / 16, (int)(player.position.Y + player.height / 2) / 16, 0.8f, 0.95f, 1f);
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(180, 50);
			recipe.AddIngredient(88, 1);
			recipe.AddIngredient(410, 1);
			recipe.AddIngredient(411, 1);
			recipe.AddTile(114);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}