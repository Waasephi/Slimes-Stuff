using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Items.Melee
{
	public class InfernalBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Infernal Blade");
			Tooltip.SetDefault("Use the power of the underworld to cut your enemies down.");
		}
		public override void SetDefaults()
		{
			item.damage = 40;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.sellPrice(0, 0, 40, 0);
			item.value = Item.buyPrice(0, 1, 50, 0);
			item.shoot = 15;
            item.shootSpeed = 4f;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("OurStuffAddon:EvilBlade");
            recipe.AddIngredient(ItemID.HellstoneBar, 20);
            recipe.AddTile(mod, "SpiritInfuser");
            recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
