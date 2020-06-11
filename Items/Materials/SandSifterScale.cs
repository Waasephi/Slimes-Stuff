using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Items.Materials
{
	public class SandSifterScale : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sand Sifter Scale");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;                 //this is where you set the max stack of item
			item.consumable = false;           //this make that the item is consumable when used
			item.width = 26;
			item.height = 44;
			item.value = 100;
			item.rare = ItemRarityID.Orange;
			item.expert = false;
			item.autoReuse = true;
		}
	}
}