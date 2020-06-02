using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Melee
{
	public class InfernalBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Infernal Blade");
			Tooltip.SetDefault("Use the power of the Underworld to cut your enemies down.");
		}

		public override void SetDefaults()
		{
			item.damage = 40;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 6;
			item.value = 10000;
			item.shoot = ProjectileID.BallofFire;
			item.shootSpeed = 4f;
			item.rare = ItemRarityID.Green;
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