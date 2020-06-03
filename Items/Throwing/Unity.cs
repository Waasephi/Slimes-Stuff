using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Throwing
{
	public class Unity : ModItem

	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unity");
		}

		public override void SetDefaults()
		{
			item.damage = 100;           //this is the item damage
			item.thrown = true;             //this make the item do throwing damage
			item.noMelee = true;
			item.width = 22;
			item.height = 22;
			item.useTime = 13;       //this is how fast you use the item
			item.useAnimation = 13;   //this is how fast the animation when the item is used
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 4;
			item.value = 10;
			item.rare = ItemRarityID.Green;
			item.reuseDelay = 6;    //this is the item delay
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;       //this make the item auto reuse
			item.shoot = ModContent.ProjectileType<UnityProjectile>();
			item.shootSpeed = 10f;     //projectile speed
			item.useTurn = true;
			item.maxStack = 1;       //this is the max stack of this item
			item.consumable = false;  //this make the item consumable when used
			item.noUseGraphic = true;
		}

		public override void AddRecipes()  //How to craft this item
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("OurStuffAddon:TrueEvilDagger");
			recipe.AddIngredient(mod, "TrueHolyDagger");
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(80)); // 20 degree spread.
																											// Here we manually spawn the 2nd projectile, manually specifying the projectile type that we wish to shoot.
			Projectile.NewProjectile(position.X - 20, position.Y, speedX *= 0.6f, speedY *= 0.6f, ModContent.ProjectileType<UTrueNightDaggerProjectile>(), damage, knockBack, player.whoAmI);
			Projectile.NewProjectile(position.X - 20, position.Y, speedX *= 0.8f, speedY *= 0.8f, ModContent.ProjectileType<UTrueClotDaggerProjectile>(), damage, knockBack, player.whoAmI);
			Projectile.NewProjectile(position.X - 20, position.Y, speedX *= 1, speedY *= 1, ModContent.ProjectileType<UTrueHolyDaggerProjectile>(), damage, knockBack, player.whoAmI);
			return true;
		}
	}
}