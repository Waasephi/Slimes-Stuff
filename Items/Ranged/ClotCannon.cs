using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Ranged
{
	public class ClotCannon : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Clot Cannon");
		}

		public override void SetDefaults()
		{
			item.damage = 43;
			item.ranged = true;
			item.width = 36;
			item.height = 28;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 5;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item41;
			item.autoReuse = false;
			item.shoot = 10;    //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 12f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "SporeBlaster", 1);
			recipe.AddIngredient(mod, "AncientBlaster", 1);
			recipe.AddIngredient(mod, "BurningBlaster", 1);
			recipe.AddIngredient(mod, "BloodBlaster", 1);
			recipe.AddTile(26);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}