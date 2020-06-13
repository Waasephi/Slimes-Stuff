using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Materials
{
	public class LavaShard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lava Shard");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(10, 5));
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;                 //this is where you set the max stack of item
			item.consumable = false;           //this make that the item is consumable when used
			item.width = 32;
			item.height = 19;
			item.value = 100;
			item.rare = ItemRarityID.Red;
			item.expert = false;
			item.autoReuse = true;
		}
	}
}