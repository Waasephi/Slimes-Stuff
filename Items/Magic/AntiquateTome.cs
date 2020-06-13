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
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.knockBack = 2;
			item.value = 10500;
			item.rare = ItemRarityID.Orange;
			item.UseSound = SoundID.Item8;
			item.autoReuse = true;
			item.shoot = ProjectileID.BoneGloveProj;
			item.shootSpeed = 8f;
			item.mana = 4;
			item.noMelee = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SoulofAntiquity>(), 15);
			recipe.AddIngredient(ModContent.ItemType<RelicShard>(), 20);
			recipe.AddIngredient(ItemID.SpellTome);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}