using Terraria.ModLoader;

namespace OurStuffAddon.Items.Materials
{
	public class RelicShard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Relic Shard");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;                 //this is where you set the max stack of item
			item.consumable = false;           //this make that the item is consumable when used
			item.width = 28;
			item.height = 42;
			item.value = 10000;
			item.rare = -1;
			item.expert = false;
			item.autoReuse = true;
		}
	}
}