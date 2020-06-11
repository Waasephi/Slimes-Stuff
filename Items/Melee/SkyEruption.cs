using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Melee
{
	public class SkyEruption : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sky Eruption");
		}

		public override void SetDefaults()
		{
			item.damage = 25;
			item.melee = true;
			item.width = 34;
			item.height = 40;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.shoot = ProjectileID.Starfury;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 7f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BoneSword);
			recipe.AddIngredient(ItemID.IceBlade);
			recipe.AddIngredient(ItemID.Starfury);
			recipe.AddIngredient(ItemID.EnchantedSword);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Here we manually spawn the 2nd projectile, manually specifying the projectile type that we wish to shoot.
			Projectile.NewProjectile(position.X, position.Y, speedX *= 2, speedY *= 2, ProjectileID.EnchantedBeam, damage, knockBack, player.whoAmI);
			Projectile.NewProjectile(position.X, position.Y, speedX *= 2, speedY *= 2, ProjectileID.IceBolt, damage, knockBack, player.whoAmI);
			return true;
		}
	}
}