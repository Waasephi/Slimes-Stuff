using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Accessories
{
	public class GiantSandSifterEye : ModItem //replace ItemName with the name of your accessory
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sand Sifter Eye");
			Tooltip.SetDefault("Wait... They have eyes? (+1 minion, gives good sight, and gives 3 defence)");
		}

		public override void UpdateAccessory(Player player, bool hideVisual) //Where it says "p" is the variable used to represent "player". In this case, every p stands for player. This is called when the accessory is on.
		{
			player.maxMinions += 1;
			player.statDefense += 3;
			player.detectCreature = true;
			player.dangerSense = true;
			player.findTreasure = true;
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
			item.expert = true;
		}
	}
}