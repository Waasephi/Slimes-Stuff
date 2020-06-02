using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Materials
{
	public class RainEssence : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rain Essence");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(3, 8));
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;                 //this is where you set the max stack of item
			item.consumable = false;           //this make that the item is consumable when used
			item.width = 26;
			item.height = 16;
			item.value = 100;
			item.rare = 1;
			item.expert = false;
			item.autoReuse = true;
		}
	}
}