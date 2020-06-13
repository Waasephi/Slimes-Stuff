using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Materials
{
	public class SpiritInfusedBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spirit Infused Bar");
			Tooltip.SetDefault("It eminates refined emotion.");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;                 //this is where you set the max stack of item
			item.consumable = false;           //this make that the item is consumable when used
			item.width = 14;
			item.height = 28;
			item.value = 100;
			item.rare = ItemRarityID.Cyan;
			item.expert = false;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SpiriciteCrystal>(), 5);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 2);
			recipe.AddIngredient(ItemID.Ectoplasm, 2);
			recipe.AddTile(mod, "SpiritInfuser");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}