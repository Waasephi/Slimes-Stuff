using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Throwing
{
	public class InfiniteDesertFang : ModItem

	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Infinite Desert Fang");
		}

		public override void SetDefaults()
		{
			item.damage = 19;           //this is the item damage
			item.thrown = true;             //this make the item do throwing damage
			item.noMelee = true;
			item.width = 22;
			item.height = 22;
			item.useTime = 12;       //this is how fast you use the item
			item.useAnimation = 12;   //this is how fast the animation when the item is used
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 10;
			item.rare = 2;
			item.reuseDelay = 6;    //this is the item delay
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;       //this make the item auto reuse
			item.shoot = mod.ProjectileType("DesertFangProjectile");
			item.shootSpeed = 7f;     //projectile speed
			item.useTurn = true;
			item.maxStack = 1;       //this is the max stack of this item
			item.consumable = false;  //this make the item consumable when used
			item.noUseGraphic = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddTile(TileID.Anvils);
			recipe.AddIngredient(mod, "DesertFang", 999);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}