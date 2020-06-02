using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Items.Melee
{
	public class HallowedBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hallowed Blade");
			Tooltip.SetDefault("Use the power of the Hallowed to cut your enemies down.");
		}
		public override void SetDefaults()
		{
			item.damage = 65;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.sellPrice(0, 3, 0, 0);
			item.value = Item.buyPrice(0, 5, 0, 0);
			item.shoot = 156;
            item.shootSpeed = 6f;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "VenomBlade");
            recipe.AddIngredient(ItemID.HallowedBar, 20);
            recipe.AddTile(mod, "SpiritInfuser");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
