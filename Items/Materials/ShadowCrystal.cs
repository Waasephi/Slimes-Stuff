using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Materials
{
	public class ShadowCrystal : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shadow Crystal");
			Tooltip.SetDefault("It sparkles in the darkness.");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;                 //this is where you set the max stack of item
			item.consumable = false;           //this make that the item is consumable when used
			item.width = 18;
			item.height = 22;
			item.value = 5000;
			item.rare = ItemRarityID.White;
			item.expert = false;
			item.autoReuse = true;
		}
	}
}