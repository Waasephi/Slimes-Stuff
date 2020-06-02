using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Vanity.Plumbers
{
	[AutoloadEquip(EquipType.Body)]
	public class MShirt : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("M Shirt");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 24;
			item.value = 100;
			item.rare = ItemRarityID.Green;
			item.vanity = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 10);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}