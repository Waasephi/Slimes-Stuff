using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Magic
{
	public class Stick : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stick");
			Tooltip.SetDefault("The go to for any beginning wizard");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 5;
			item.magic = true;
			item.width = 22;
			item.height = 22;
			item.useTime = 40;
			item.useAnimation = 40;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 100;
			item.rare = 6;
			item.UseSound = SoundID.Item43;
			item.autoReuse = false;
			item.shoot = mod.ProjectileType("StickProjectile");
			item.shootSpeed = 6f;
			item.mana = 2;
			item.noMelee = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 100);
			recipe.AddIngredient(ItemID.FallenStar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}