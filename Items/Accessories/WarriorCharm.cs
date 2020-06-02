using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Items.Accessories
{
	public class WarriorCharm : ModItem //replace ItemName with the name of your accessory
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Warrior Charm");
			Tooltip.SetDefault("Harness the power of the Body and push your Strength beyond (Raises Melee Damage By 1/3 But Lowers Melee Speed).");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.meleeDamage += .3f;
			player.meleeSpeed -= .1f;
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
			recipe.AddIngredient(ItemID.Ruby, 50);
			recipe.AddIngredient(ItemID.MoltenHelmet, 1);
			recipe.AddIngredient(ItemID.MoltenBreastplate, 1);
			recipe.AddIngredient(ItemID.MoltenGreaves, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}