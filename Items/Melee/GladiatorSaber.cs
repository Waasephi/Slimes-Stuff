using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Melee
{
	public class GladiatorSaber : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gladiator Saber");
			Tooltip.SetDefault("A sword used by fierce ancient warriors.");
		}

		public override void SetDefaults()
		{
			item.damage = 25;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 30;
			item.useAnimation = 30;
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
			recipe.AddIngredient(ItemID.IronBar, 30);
			recipe.AddIngredient(ItemID.MarbleBlock, 50);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}