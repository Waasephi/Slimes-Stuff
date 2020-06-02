using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Items.Materials
{
	public class EnchantedLeaf : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Suspicious Leaf");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;                 //this is where you set the max stack of item
			item.consumable = false;           //this make that the item is consumable when used
			item.width = 32;
			item.height = 19;
			item.value = 100;
			item.rare = ItemRarityID.Lime;
			item.expert = false;
			item.autoReuse = true;
		}
	}
}