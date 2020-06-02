using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Tools
{
	public class PhasiteAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Phasite Axe");
		}

		public override void SetDefaults()
		{
			item.damage = 25;
			item.melee = true;
			item.width = 32;
			item.height = 28;
			item.useTime = 28;
			item.useAnimation = 28;
			item.axe = 15;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "PhasiteBar", 14);
			recipe.AddIngredient(ItemID.Wood, 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}