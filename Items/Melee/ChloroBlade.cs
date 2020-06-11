using Terraria.ID;
using Terraria.ModLoader;

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
			item.damage = 80;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 14;
			item.useAnimation = 14;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 6;
			item.value = 10000;
			item.shoot = ProjectileID.SporeCloud;
			item.shootSpeed = 7f;
			item.rare = ItemRarityID.Green;
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