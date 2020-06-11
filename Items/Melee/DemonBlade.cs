using Terraria.ID;
using Terraria.ModLoader;

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
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 6;
			item.value = 10000;
			item.shoot = ProjectileID.TinyEater;
			item.shootSpeed = 3f;
			item.rare = ItemRarityID.Green;
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