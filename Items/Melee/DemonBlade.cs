using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Items.Melee
{
	public class DemonBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Demon Blade");
			Tooltip.SetDefault("Use the power of the corruption to cut your enemies down.");
		}
		public override void SetDefaults()
		{
			item.damage = 20;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 22;
			item.useAnimation = 22;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.value = Item.buyPrice(0, 1, 0, 0);
			item.shoot = 307;
            item.shootSpeed = 3f;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "SpiritSword");
            recipe.AddIngredient(ItemID.DemoniteBar, 20);
            recipe.AddTile(mod, "SpiritInfuser");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
