using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Accessories
{
	public class AncientPebbleItem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient Pebble");
			Tooltip.SetDefault("It Shouldn't Be As Useful As It Is... (+7% To All Damage)");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.allDamage *= 1.07f;
			player.detectCreature = true;
			player.dangerSense = true;
			player.findTreasure = true;
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 10000;
			item.rare = -1;
			item.accessory = true;
			item.expert = true;
		}
	}
}