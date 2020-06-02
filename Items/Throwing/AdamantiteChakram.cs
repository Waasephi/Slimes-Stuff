using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Throwing
{
	public class AdamantiteChakram : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Adamantite Chakram");
		}

		public override void SetDefaults()
		{
			item.damage = 45;
			item.thrown = true;
			item.width = 30;
			item.height = 30;
			item.useTime = 20;
			item.useAnimation = 20;
			item.noUseGraphic = true;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 3;
			item.value = 8;
			item.rare = ItemRarityID.LightPurple;
			item.shootSpeed = 12f;
			item.shoot = mod.ProjectileType("AdamantiteChakramProjectile");
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()  //How to craft this item
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AdamantiteBar, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}