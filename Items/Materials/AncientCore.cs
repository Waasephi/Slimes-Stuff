using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Materials
{
	public class AncientCore : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Core");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;                 //this is where you set the max stack of item
			item.consumable = false;           //this make that the item is consumable when used
			item.width = 38;
			item.height = 44;
			item.value = 100;
			item.rare = ItemRarityID.Blue;
			item.expert = false;
			item.autoReuse = true;
		}
	}
}