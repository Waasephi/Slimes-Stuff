using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Throwing
{
	public class TitaniumChakram : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Titanium Chakram");
		}

		public override void SetDefaults()
		{
			item.damage = 50;
			item.thrown = true;
			item.width = 30;
			item.height = 30;
			item.useTime = 17;
			item.useAnimation = 17;
			item.noUseGraphic = true;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 3;
			item.value = 8;
			item.rare = ItemRarityID.LightPurple;
			item.shootSpeed = 12f;
			item.shoot = mod.ProjectileType("TitaniumChakramProjectile");
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()  //How to craft this item
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TitaniumBar, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}