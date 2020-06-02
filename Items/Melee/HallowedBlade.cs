using Terraria.ID;
using Terraria.ModLoader;

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
			item.damage = 60;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 6;
			item.value = 10000;
			item.shoot = ProjectileID.LightBeam;
			item.shootSpeed = 6f;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "InfernalBlade");
			recipe.AddIngredient(ItemID.HallowedBar, 20);
			recipe.AddTile(mod, "SpiritInfuser");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}