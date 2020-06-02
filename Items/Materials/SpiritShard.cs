using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Items.Materials
{
	public class SpiritShard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spirit Essence");
			Tooltip.SetDefault("A fragment of emotion");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(4, 4));
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;                 //this is where you set the max stack of item
			item.consumable = false;           //this make that the item is consumable when used
			item.width = 22;
			item.height = 22;
			item.value = 9000;
			item.rare = ItemRarityID.Cyan;
			item.expert = false;
			item.autoReuse = true;
		}
	}
}