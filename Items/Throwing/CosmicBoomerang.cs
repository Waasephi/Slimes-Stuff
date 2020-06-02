using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Throwing
{
	public class CosmicBoomerang : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cosmic Boomerang");
		}

		public override void SetDefaults()
		{
			item.damage = 90;
			item.thrown = true;
			item.width = 30;
			item.height = 30;
			item.useTime = 10;
			item.useAnimation = 10;
			item.noUseGraphic = true;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 8;
			item.rare = 6;
			item.shootSpeed = 12f;
			item.shoot = mod.ProjectileType("CosmicBoomerangProjectile");
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()  //How to craft this item
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "CosmicFragment", 18);
			recipe.AddTile(412);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}