using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Items.Accessories
{
	[AutoloadEquip(EquipType.Wings)]
	public class InfinityFloater : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Your sky high journey seems like it will never end (? wing time, 3 accel");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 1000000000;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.08f;
			maxCanAscendMultiplier = 0.8f;
			maxAscentMultiplier = 2f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 12f;
			acceleration *= 3f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 1000);
			recipe.AddIngredient(575, 1000);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}