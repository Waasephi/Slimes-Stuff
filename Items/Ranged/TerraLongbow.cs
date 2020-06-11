using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Ranged
{
	public class TerraLongbow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Terra Longbow");
			Tooltip.SetDefault("This bow eminates the energy of the earth.");
		}

		public override void SetDefaults()
		{
			item.damage = 80;
			item.noMelee = true;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = ProjectileID.UnholyArrow;
			item.shootSpeed = 15f;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 12;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "TrueNightsShot");
			recipe.AddIngredient(mod, "TrueHallowedRepeater");
			recipe.AddIngredient(mod, "BrokenHeroBow");
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}