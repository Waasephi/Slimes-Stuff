using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Items.Accessories
{
	public class SummonerCharm : ModItem //replace ItemName with the name of your accessory
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Summoner Charm");
			Tooltip.SetDefault("Harness the power of the Mind and push your Leadership beyond (Lowers Minion Damage By 1/5 But Gives 2 Minion Slots).");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.minionDamage -= .2f;
			player.maxMinions += 2;
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
			recipe.AddIngredient(ItemID.Amber, 50);
			recipe.AddIngredient(ItemID.BeeHeadgear, 1);
			recipe.AddIngredient(ItemID.BeeBreastplate, 1);
			recipe.AddIngredient(ItemID.BeeGreaves, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}