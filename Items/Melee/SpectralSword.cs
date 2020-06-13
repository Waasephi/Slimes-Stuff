using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Melee
{
	public class SpectralSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spectral Sword");
			Tooltip.SetDefault("Perfect for musical avians!");
		}

		public override void SetDefaults()
		{
			item.damage = 50;
			item.melee = true;
			item.width = 62;
			item.height = 62;
			item.useTime = 35;
			item.useAnimation = 35;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = Item.sellPrice(0, 15, 0, 0);
			item.value = Item.buyPrice(0, 25, 0, 0);
			item.shoot = mod.ProjectileType("SpectralDuck");
			item.UseSound = SoundID.Item1;
			item.shootSpeed = 6f;
			item.expert = true;
			item.rare = 2;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AdamantiteBar, 18);
			recipe.AddIngredient(ItemID.Duck, 20);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}