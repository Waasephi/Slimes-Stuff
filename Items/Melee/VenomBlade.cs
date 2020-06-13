using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Melee
{
	public class VenomBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Venom Blade");
			Tooltip.SetDefault("Use the power of the Venom to cut your enemies down.");
		}

		public override void SetDefaults()
		{
			item.damage = 57;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.sellPrice(0, 1, 0, 0);
			item.value = Item.buyPrice(0, 3, 0, 0);
			item.shoot = 355;
			item.shootSpeed = 6f;
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<InfernalBlade>());
			recipe.AddIngredient(ItemID.SpiderFang, 20);
			recipe.AddTile(mod, "SpiritInfuser");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}