using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Accessories
{
	public class WizardCharm : ModItem //replace ItemName with the name of your accessory
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wizard Charm");
			Tooltip.SetDefault("Harness the power of the soul and push your Magic beyond (Increases Magic Damage By 1/3 But Doubles Mana Cost).");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.magicDamage += .3f;
			player.manaCost = 2f;
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
			recipe.AddIngredient(ItemID.Sapphire, 50);
			recipe.AddIngredient(228, 1);
			recipe.AddIngredient(229, 1);
			recipe.AddIngredient(230, 1);
			recipe.AddTile(114);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}