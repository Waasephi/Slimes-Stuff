using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Magic
{
	public class RainbowStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rainbow Staff");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 15;
			item.magic = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 100;
			item.rare = 6;
			item.UseSound = SoundID.Item43;
			item.autoReuse = true;
			item.shoot = 126;
			item.shootSpeed = 6f;
			item.mana = 15;
			item.noMelee = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ShadowStaff");
			recipe.AddIngredient(mod, "SeafoamStaff");
			recipe.AddIngredient(ItemID.TopazStaff);
			recipe.AddIngredient(ItemID.AmethystStaff);
			recipe.AddIngredient(ItemID.SapphireStaff);
			recipe.AddIngredient(ItemID.EmeraldStaff);
			recipe.AddIngredient(ItemID.RubyStaff);
			recipe.AddIngredient(ItemID.DiamondStaff);
			recipe.AddIngredient(ItemID.AmberStaff);
			recipe.AddIngredient(ItemID.MagicMissile);
			recipe.AddTile(26);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		// How can I shoot 2 different projectiles at the same time?
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Here we manually spawn the 2nd projectile, manually specifying the projectile type that we wish to shoot.
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.AmberBolt, damage, knockBack, player.whoAmI);
			// By returning true, the vanilla behavior will take place, which will shoot the 1st projectile, the one determined by the ammo.
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.AmethystBolt, damage, knockBack, player.whoAmI);
			// By returning true, the vanilla behavior will take place, which will shoot the 1st projectile, the one determined by the ammo.
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.SapphireBolt, damage, knockBack, player.whoAmI);
			// By returning true, the vanilla behavior will take place, which will shoot the 1st projectile, the one determined by the ammo.
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.TopazBolt, damage, knockBack, player.whoAmI);
			// By returning true, the vanilla behavior will take place, which will shoot the 1st projectile, the one determined by the ammo.
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.RubyBolt, damage, knockBack, player.whoAmI);
			// By returning true, the vanilla behavior will take place, which will shoot the 1st projectile, the one determined by the ammo.
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.EmeraldBolt, damage, knockBack, player.whoAmI);
			// By returning true, the vanilla behavior will take place, which will shoot the 1st projectile, the one determined by the ammo.
			return true;
		}
	}
}