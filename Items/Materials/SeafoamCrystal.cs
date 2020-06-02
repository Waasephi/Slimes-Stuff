using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Items.Materials
{
	public class SeafoamCrystal : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Seafoam Crystal");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;                 //this is where you set the max stack of item
			item.consumable = true;           //this make that the item is consumable when used
			item.width = 22;
			item.height = 24;
			item.value = 1000;
			item.rare = ItemRarityID.Green;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.expert = false;
			item.autoReuse = true;
			item.useTurn = true;
		}
	}
}