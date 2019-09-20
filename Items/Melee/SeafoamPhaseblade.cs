using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Melee
{
	public class SeafoamPhaseblade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Seafoam Phaseblade");
		}
		public override void SetDefaults()
		{
			item.damage = 21;
			item.melee = true;
			item.width = 48;
			item.height = 48;
			item.useTime = 24;
			item.useAnimation = 24;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item15;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "SeafoamCrystal", 10);
            recipe.AddIngredient(ItemID.MeteoriteBar, 15);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
