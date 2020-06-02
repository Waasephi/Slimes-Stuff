using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Magic
{
	public class PalladiumStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Palladium Staff");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 31;
			item.magic = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 2;
			item.value = 100;
			item.rare = ItemRarityID.LightPurple;
			item.UseSound = SoundID.Item43;
			item.autoReuse = true;
			item.shoot = ProjectileID.AmberBolt;
			item.shootSpeed = 8f;
			item.mana = 16;
			item.noMelee = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PalladiumBar, 12);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}