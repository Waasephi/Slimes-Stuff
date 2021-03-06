using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Magic
{
	public class CobaltStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cobalt Staff");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 29;
			item.magic = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 23;
			item.useAnimation = 23;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 2;
			item.value = 100;
			item.rare = ItemRarityID.LightPurple;
			item.UseSound = SoundID.Item43;
			item.autoReuse = true;
			item.shoot = ProjectileID.SapphireBolt;
			item.shootSpeed = 8f;
			item.mana = 15;
			item.noMelee = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CobaltBar, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}