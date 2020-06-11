using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Magic
{
	public class PhasiteTome : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Phasite Tome");
		}

		public override void SetDefaults()
		{
			item.damage = 21;
			item.magic = true;
			item.width = 30;
			item.height = 32;
			item.useTime = 36;
			item.useAnimation = 36;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 2;
			item.value = 100;
			item.rare = ItemRarityID.LightPurple;
			item.UseSound = SoundID.Item8;
			item.autoReuse = true;
			item.shoot = ProjectileID.ClothiersCurse;
			item.shootSpeed = 6f;
			item.mana = 5;
			item.noMelee = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "PhasiteBar", 15);
			recipe.AddIngredient(ItemID.Book);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}