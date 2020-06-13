using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Melee
{
	public class AwokenMasterSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Awoken Master Sword");
			Tooltip.SetDefault("A sword used by a masterful warrior. It has shown its true power.");
		}

		public override void SetDefaults()
		{
			item.damage = 100;
			item.melee = true;
			item.width = 344;
			item.height = 344;
			item.shoot = ProjectileID.SwordBeam;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shootSpeed = 8f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<MasterSword>());
			recipe.AddIngredient(ItemID.BrokenHeroSword, 3);
			recipe.AddIngredient(ItemID.TerraBlade, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}