using OurStuffAddon.Projectiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Ranged.Ammo
{
	public class SpiritArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spirit Arrow");
			Tooltip.SetDefault("Pierces the soul.");
		}

		public override void SetDefaults()
		{
			item.damage = 5;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 1.5f;
			item.value = 1;
			item.rare = ItemRarityID.Blue;
			item.shoot = ModContent.ProjectileType<SpiritArrowProjectile>();   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 5f;                  //The speed of the projectile
			item.ammo = AmmoID.Arrow;              //The ammo class this ammo belongs to.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "SpiriciteCrystal");
			recipe.AddTile(mod, "SpiritInfuser");
			recipe.SetResult(this, 150);
			recipe.AddRecipe();
		}
	}
}