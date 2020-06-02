using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Melee
{
	public class MasterSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Master Sword");
			Tooltip.SetDefault("A sword used by a masterful warrior. It looks like it is missing something.");
		}

		public override void SetDefaults()
		{
			item.damage = 50;
			item.melee = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.NightsEdge, 1);
			recipe.AddIngredient(ItemID.HellstoneBar, 50);
			recipe.AddTile(26);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}