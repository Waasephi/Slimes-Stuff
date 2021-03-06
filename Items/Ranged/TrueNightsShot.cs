using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Ranged
{
	public class TrueNightsShot : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Night's Shot");
			Tooltip.SetDefault("This bow eminates powerful dark energy.");
		}

		public override void SetDefaults()
		{
			item.damage = 80;
			item.noMelee = true;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = ProjectileID.UnholyArrow;
			item.shootSpeed = 10f;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Purple;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<NightsShot>());
			recipe.AddIngredient(ModContent.ItemType<BrokenHeroBow>());
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}