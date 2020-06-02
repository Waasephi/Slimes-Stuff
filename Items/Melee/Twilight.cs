using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Melee
{
	public class Twilight : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Twilight");
		}

		public override void SetDefaults()
		{
			item.damage = 60;
			item.melee = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = ItemRarityID.Red;
			item.shoot = ProjectileID.BlackBolt;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 8f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "Daylight");
			recipe.AddIngredient(mod, "Moonlight");
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Here we manually spawn the 2nd projectile, manually specifying the projectile type that we wish to shoot.
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.SkyFracture, damage, knockBack, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.SkyFracture, damage, knockBack, player.whoAmI);
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(25));
			return true;
		}
	}
}