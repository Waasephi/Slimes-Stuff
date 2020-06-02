using Terraria.ModLoader;

namespace OurStuffAddon.Items.Materials
{
	public class TaintedCore : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tainted Core");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;                 //this is where you set the max stack of item
			item.consumable = false;           //this make that the item is consumable when used
			item.width = 42;
			item.height = 42;
			item.value = 100;
			item.rare = 8;
			item.expert = false;
			item.autoReuse = true;
		}
	}
}