using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Throwing
{
	public class PebbleSack : ModItem

	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pebble Sack");
		}

		public override void SetDefaults()
		{
			item.damage = 32;           //this is the item damage
			item.thrown = true;             //this make the item do throwing damage
			item.noMelee = true;
			item.width = 22;
			item.height = 22;
			item.useTime = 10;       //this is how fast you use the item
			item.useAnimation = 10;   //this is how fast the animation when the item is used
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 4;
			item.value = 10;
			item.rare = -1;
			item.reuseDelay = 6;    //this is the item delay
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;       //this make the item auto reuse
			item.shoot = ProjectileID.Seed;
			item.shootSpeed = 10f;     //projectile speed
			item.useTurn = true;
			item.maxStack = 999;       //this is the max stack of this item
			item.consumable = false;  //this make the item consumable when used
			item.noUseGraphic = true;
		}

		public override void AddRecipes()  //How to craft this item
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ChippedStone", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 333);
			recipe.AddRecipe();
		}
	}
}