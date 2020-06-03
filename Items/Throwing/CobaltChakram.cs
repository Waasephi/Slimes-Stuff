using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Throwing
{
	public class CobaltChakram : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cobalt Chakram");
		}

		public override void SetDefaults()
		{
			item.damage = 25;
			item.thrown = true;
			item.width = 30;
			item.height = 30;
			item.useTime = 27;
			item.useAnimation = 27;
			item.noUseGraphic = true;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 3;
			item.value = 8;
			item.rare = ItemRarityID.LightPurple;
			item.shootSpeed = 12f;
			item.shoot = ModContent.ProjectileType<CobaltChakramProjectile>();
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()  //How to craft this item
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CobaltBar, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}