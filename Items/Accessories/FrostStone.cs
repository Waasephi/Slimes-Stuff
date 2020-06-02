using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Accessories
{
	public class FrostStone : ModItem //replace ItemName with the name of your accessory
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Frost Stone");
			Tooltip.SetDefault("Cold to the touch. (Gives Frostburn To Melee And Ranged Weapons)");
		}

		public override void UpdateAccessory(Player player, bool hideVisual) //Where it says "p" is the variable used to represent "player". In this case, every p stands for player. This is called when the accessory is on.
		{
			player.frostBurn = true;
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 10000;
			item.rare = 2;
			item.accessory = true;
		}
	}
}