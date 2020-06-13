using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Melee
{
	public class SolarBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Solar Blade");
			Tooltip.SetDefault("Use the power of the Sun to cut your enemies down.");
		}

		public override void SetDefaults()
		{
			item.damage = 120;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.sellPrice(0, 11, 0, 0);
			item.value = Item.buyPrice(0, 25, 0, 0);
			item.shoot = 295;
			item.shootSpeed = 8f;
			item.rare = 2;
			item.UseSound = SoundID.Item103;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<TrueSpiritBlade>());
			recipe.AddIngredient(3458, 20);
			recipe.AddTile(mod, "SpiritInfuser");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}