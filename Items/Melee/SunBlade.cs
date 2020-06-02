using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Melee
{
	public class SunBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sun Blade");
		}

		public override void SetDefaults()
		{
			item.damage = 50;
			item.melee = true;
			item.width = 58;
			item.height = 58;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = ItemRarityID.Red;
			item.shoot = ProjectileID.DD2PhoenixBowShot;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 8f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			// Here we manually spawn the 2nd projectile, manually specifying the projectile type that we wish to shoot.
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.MonkStaffT2Ghast, damage, knockBack, player.whoAmI);
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(25));
			return true;
		}
	}
}