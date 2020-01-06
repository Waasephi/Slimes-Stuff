using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Ranged
{
	public class ParepheneRepeater : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Parephene Repeater");
		}
		public override void SetDefaults()
		{
			item.damage = 45;
			item.noMelee = true;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 5;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 4;
			item.shootSpeed = 12f;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 11;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "ParepheneBar", 14);
            recipe.AddTile(134);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
