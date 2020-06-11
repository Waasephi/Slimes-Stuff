using OurStuffAddon.Projectiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Ranged.Ammo
{
	public class InfiniteSplinteredShot : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Endless Splintered Shot");
			Tooltip.SetDefault("It does not seem very painful... even though its pretty sharp, But you will never run out");
		}

		public override void SetDefaults()
		{
			item.damage = 1;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 1.5f;
			item.value = 1;
			item.rare = ItemRarityID.Blue;
			item.shoot = ModContent.ProjectileType<SplinteredShotProjectile>();   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 16f;                  //The speed of the projectile
			item.ammo = AmmoID.Bullet;              //The ammo class this ammo belongs to.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "SplinteredShot", 3996);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}