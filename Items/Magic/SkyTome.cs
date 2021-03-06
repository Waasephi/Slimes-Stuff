using OurStuffAddon.Items.Materials;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Magic
{
	public class SkyTome : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sky Tome");
		}

		public override void SetDefaults()
		{
			item.damage = 25;
			item.magic = true;
			item.width = 30;
			item.height = 32;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 2;
			item.value = 100;
			item.rare = ItemRarityID.LightPurple;
			item.UseSound = SoundID.Item21;
			item.autoReuse = false;
			item.shoot = ProjectileID.BookStaffShot;
			item.shootSpeed = 7f;
			item.mana = 10;
			item.noMelee = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SkyEssence>(), 20);
			recipe.AddTile(TileID.SkyMill);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}