using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Ranged
{
	public class SkeletalBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Skeletal Bow");
			Tooltip.SetDefault("Somehow this bow is still useable after so long.");
		}

		public override void SetDefaults()
		{
			item.damage = 30;
			item.noMelee = true;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = ProjectileID.UnholyArrow;
			item.shootSpeed = 10f;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = ItemRarityID.Purple;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bone, 150);
			recipe.AddIngredient(ItemID.Cobweb, 200);
			recipe.AddTile(TileID.BoneWelder);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}