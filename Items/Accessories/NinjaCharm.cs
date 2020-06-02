using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Items.Accessories
{
	public class NinjaCharm : ModItem //replace ItemName with the name of your accessory
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ninja Charm");
			Tooltip.SetDefault("Harness the power of the spirit and push your Throwing beyond (Increases Throwing Damage By 1/3 But Lowers Attack Speed).");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.thrownDamage += .3f;
			player.meleeSpeed -= .2f;
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
			recipe.AddIngredient(ItemID.Diamond, 50);
			recipe.AddIngredient(ItemID.FossilHelm, 1);
			recipe.AddIngredient(ItemID.FossilShirt, 1);
			recipe.AddIngredient(ItemID.FossilPants, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}