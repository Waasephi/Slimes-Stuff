using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Ranged
{
	public class PlagueWoodBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Plague Wood Bow");
		}
		public override void SetDefaults()
		{
			item.damage = 10;
			item.noMelee = true;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 28;
			item.useAnimation = 28;
			item.useStyle = 5;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 4;
			item.shootSpeed = 10f;
			item.knockBack = 6;
			item.value = 1000;
			item.rare = 2;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod,"PlagueWood", 10);
			recipe.AddTile(18);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
