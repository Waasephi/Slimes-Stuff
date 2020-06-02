using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Ranged
{
	public class NightsShot : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Night's Shot");
			Tooltip.SetDefault("This bow eminates dark energy.");
		}

		public override void SetDefaults()
		{
			item.damage = 50;
			item.noMelee = true;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
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
			recipe.AddIngredient(ItemID.DemonBow, 1);
			recipe.AddIngredient(ItemID.BeesKnees, 1);
			recipe.AddIngredient(ItemID.MoltenFury, 1);
			recipe.AddIngredient(mod, "SkeletalBow");
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}