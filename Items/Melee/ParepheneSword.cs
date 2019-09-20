using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Melee
{
	public class ParepheneSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Parephene Sword");
		}
		public override void SetDefaults()
		{
			item.damage = 48;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 2;
            item.shoot = 228;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.shootSpeed = 6f;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ParepheneBar", 10);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
