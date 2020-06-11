using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Materials
{
	public class LuminaFragment : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lumina Fragment");
			Tooltip.SetDefault("You can feel the emotional power radiating from it." +
								"\n[c/00f2ff:-Spirit Class-]");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;                 //this is where you set the max stack of item
			item.consumable = false;           //this make that the item is consumable when used
			item.width = 32;
			item.height = 32;
			item.value = 100;
			item.rare = ItemRarityID.Cyan;
			item.expert = false;
			item.autoReuse = true;
			ItemID.Sets.ItemNoGravity[item.type] = true;
			ItemID.Sets.ItemIconPulse[item.type] = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentSolar, 1);
			recipe.AddIngredient(ItemID.FragmentVortex, 1);
			recipe.AddIngredient(ItemID.FragmentNebula, 1);
			recipe.AddIngredient(ItemID.FragmentStardust, 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}