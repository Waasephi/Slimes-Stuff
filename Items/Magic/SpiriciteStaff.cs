using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Magic
{
	public class SpiriciteStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spiricite Staff");
			Tooltip.SetDefault("Shoots a homing spirit.");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 10;
			item.magic = true;
			item.width = 22;
			item.height = 22;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 2;
			item.value = 100;
			item.rare = ItemRarityID.LightPurple;
			item.UseSound = SoundID.Item43;
			item.autoReuse = false;
			item.shoot = ProjectileID.LostSoulFriendly;
			item.shootSpeed = 4f;
			item.mana = 2;
			item.noMelee = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SpiriciteCrystal>(), 10);
			recipe.AddTile(mod, "SpiritInfuser");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}