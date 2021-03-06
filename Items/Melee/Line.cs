using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Melee
{
	public class Line : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Line");
			Tooltip.SetDefault("What?");
		}

		public override void SetDefaults()
		{
			item.damage = 999999999;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 1;
			item.useAnimation = 1;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.noMelee = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 9999);
			recipe.AddIngredient(ItemID.DirtBlock, 9999);
			recipe.AddIngredient(ItemID.DirtBlock, 9999);
			recipe.AddIngredient(ItemID.DirtBlock, 9999);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}