using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Ranged
{
	public class IronPistol : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Iron Pistol");
			Tooltip.SetDefault("The beginning of your bullet using powers");
		}

		public override void SetDefaults()
		{
			item.damage = 6;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item11;
			item.autoReuse = false;
			item.shoot = ProjectileID.PurificationPowder;    //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 12f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}