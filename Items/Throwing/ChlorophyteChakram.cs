using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Throwing
{
	public class ChlorophyteChakram : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chlorophyte Chakram");
		}

		public override void SetDefaults()
		{
			item.damage = 60;
			item.thrown = true;
			item.width = 30;
			item.height = 30;
			item.useTime = 15;
			item.useAnimation = 15;
			item.noUseGraphic = true;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 8;
			item.rare = 6;
			item.shootSpeed = 12f;
			item.shoot = mod.ProjectileType("ChlorophyteChakramProjectile");
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()  //How to craft this item
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 15);
			recipe.AddTile(134);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}