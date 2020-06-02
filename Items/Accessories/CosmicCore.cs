using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Items.Accessories
{
	public class CosmicCore : ModItem //replace ItemName with the name of your accessory
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cosmic Core");
			Tooltip.SetDefault("Greatly Increased Thrown Velocity");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(6, 4));
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.thrownVelocity += 3f;
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.accessory = true;
			item.expert = true;
		}
	}
}