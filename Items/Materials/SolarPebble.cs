using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Items.Materials
{
	public class SolarPebble : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Solar Pebble");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(7, 11));
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;                 //this is where you set the max stack of item
			item.consumable = false;           //this make that the item is consumable when used
			item.width = 18;
			item.height = 18;
			item.value = 100;
			item.rare = ItemRarityID.Orange;
			item.expert = false;
			item.autoReuse = true;
		}
	}
}