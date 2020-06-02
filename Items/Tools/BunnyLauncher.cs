using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Tools
{
	public class BunnyLauncher : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bunny Launcher");
		}

		public override void SetDefaults()
		{
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = 10000;
			item.shoot = ProjectileID.Bunny;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.noUseGraphic = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bunny, 999);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}