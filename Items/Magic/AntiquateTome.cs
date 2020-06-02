using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Magic
{
	public class AntiquateTome : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Antiquate Tome");
		}

		public override void SetDefaults()
		{
			item.damage = 56;
			item.magic = true;
			item.width = 28;
			item.height = 30;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 10500;
			item.rare = 3;
			item.UseSound = SoundID.Item8;
			item.autoReuse = true;
			item.shoot = 532;
			item.shootSpeed = 8f;
			item.mana = 4;
			item.noMelee = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "SoulofAntiquity", 15);
			recipe.AddIngredient(mod, "RelicShard", 20);
			recipe.AddIngredient(ItemID.SpellTome);
			recipe.AddTile(101);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}