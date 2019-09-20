using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Ranged
{
	public class SkyShot : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sky Shot");
		}
		public override void SetDefaults()
		{
			item.damage = 25;
			item.noMelee = true;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 5;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 4;
			item.shootSpeed = 10f;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 11;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SkyEssence"), 20);
            recipe.AddTile(TileID.SkyMill);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
