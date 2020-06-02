using OurStuffAddon.Items.SpiritDamageClass;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Accessories
{
	public class SpiricistEmblem : ModItem //replace ItemName with the name of your accessory
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spiricist Emblem");
			Tooltip.SetDefault("+15% [c/00f2ff:Spirit Damage]." +
				"\n[c/00f2ff:-Spirit Class-]");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			SpiritDamagePlayer modPlayer = SpiritDamagePlayer.ModPlayer(player);
			modPlayer.spiritDamageMult *= 1.15f;
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = Item.sellPrice(gold: 2);
			item.rare = ItemRarityID.Green;
			item.accessory = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "SpiricistEmblem");
			recipe.AddIngredient(ItemID.SoulofMight, 5);
			recipe.AddIngredient(ItemID.SoulofFright, 5);
			recipe.AddIngredient(ItemID.SoulofSight, 5);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(ItemID.AvengerEmblem);
			recipe.AddRecipe();
		}
	}
}