using OurStuffAddon.Projectiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Throwing
{
	public class NightDagger : ModItem

	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Night Dagger");
		}

		public override void SetDefaults()
		{
			item.damage = 40;           //this is the item damage
			item.thrown = true;             //this make the item do throwing damage
			item.noMelee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 15;       //this is how fast you use the item
			item.useAnimation = 15;   //this is how fast the animation when the item is used
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 4;
			item.value = 10;
			item.rare = ItemRarityID.Green;
			item.reuseDelay = 6;    //this is the item delay
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;        //this make the item auto reuse
			item.shoot = ModContent.ProjectileType<NightDaggerProjectile>();
			item.shootSpeed = 7f;     //projectile speed
			item.useTurn = true;
			item.maxStack = 1;       //this is the max stack of this item
			item.consumable = false;  //this make the item consumable when used
			item.noUseGraphic = true;
		}

		public override void AddRecipes()  //How to craft this item
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SeafoamJavelin>(), 999);
			recipe.AddIngredient(ModContent.ItemType<DemonBoomerang>(), 2);
			recipe.AddIngredient(ModContent.ItemType<SporeBag>(), 999);
			recipe.AddIngredient(ModContent.ItemType<InfernalKunai>(), 999);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}