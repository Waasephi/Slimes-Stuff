using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Magic
{
	public class OrichalcumStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Orichalcum Staff");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 37;
			item.magic = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 26;
			item.useAnimation = 26;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 2;
			item.value = 100;
			item.rare = ItemRarityID.LightPurple;
			item.UseSound = SoundID.Item43;
			item.autoReuse = true;
			item.shoot = ProjectileID.AmethystBolt;
			item.shootSpeed = 8f;
			item.mana = 18;
			item.noMelee = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.OrichalcumBar, 12);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}