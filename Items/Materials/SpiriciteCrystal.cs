using Terraria.ModLoader;

namespace OurStuffAddon.Items.Materials
{
	public class SpiriciteCrystal : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spiricite Crystal");
			Tooltip.SetDefault("It eminates pure emotion... Its so cold.");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;                 //this is where you set the max stack of item
			item.consumable = false;           //this make that the item is consumable when used
			item.width = 18;
			item.height = 18;
			item.value = 100;
			item.rare = 9;
			item.expert = false;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "SpiritShard", 5);
			recipe.AddTile(mod, "SpiritInfuser");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}