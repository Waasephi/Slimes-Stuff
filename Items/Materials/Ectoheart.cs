using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Items.Materials
{
	public class Ectoheart : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ectoheart");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;                 //this is where you set the max stack of item
			item.consumable = false;           //this make that the item is consumable when used
			item.width = 44;
			item.height = 48;
			item.value = 100;
			item.rare = ItemRarityID.Cyan;
			item.expert = false;
			item.autoReuse = true;
		}
	}
}