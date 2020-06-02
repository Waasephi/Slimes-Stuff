using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Items.Melee
{
	public class Crimblade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("CrimBlade");
			Tooltip.SetDefault("Use the power of the crimson to cut your enemies down.");
		}
		public override void SetDefaults()
		{
			item.damage = 20;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.value = Item.buyPrice(0, 1, 0, 0);
            item.shoot = 304;
            item.shootSpeed = 8f;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "SpiritSword");
            recipe.AddIngredient(ItemID.CrimtaneBar, 20);
            recipe.AddTile(mod, "SpiritInfuser");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
