using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Materials
{
	public class BrokenHeroBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Broken Hero Bow");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(3, 1));
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;                 //this is where you set the max stack of item
			item.consumable = false;           //this make that the item is consumable when used
			item.width = 80;
			item.height = 112;
			item.value = 100;
			item.rare = 3;
			item.expert = false;
			item.autoReuse = true;
		}
	}
}