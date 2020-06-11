using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Items.Materials
{
	public class BottledDune : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bottled Dune");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;                 //this is where you set the max stack of item
			item.consumable = false;           //this make that the item is consumable when used
			item.width = 20;
			item.height = 26;
			item.value = 100;
			item.rare = ItemRarityID.Yellow;
			item.expert = false;
			item.autoReuse = true;
		}
	}
}