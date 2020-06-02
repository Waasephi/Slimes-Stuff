using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Items.Melee
{
	public class ChloroBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Chloro Blade");
			Tooltip.SetDefault("Use the power of the Jungle to cut your enemies down.");
		}
		public override void SetDefaults()
		{
			item.damage = 74;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 14;
			item.useAnimation = 14;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.sellPrice(0, 5, 0, 0);
			item.value = Item.buyPrice(0, 7, 0, 0);
			item.shoot = 228;
            item.shootSpeed = 7f;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "HallowedBlade");
            recipe.AddIngredient(ItemID.ChlorophyteBar, 20);
            recipe.AddTile(mod, "SpiritInfuser");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
