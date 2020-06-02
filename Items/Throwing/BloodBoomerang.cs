using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Throwing
{
	public class BloodBoomerang : ModItem

	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blood Boomerang");
			Tooltip.SetDefault("Stacks to 2.");
		}

		public override void SetDefaults()
		{
			item.damage = 17;           //this is the item damage
			item.thrown = true;             //this make the item do throwing damage
			item.noMelee = true;
			item.width = 24;
			item.height = 40;
			item.useTime = 15;       //this is how fast you use the item
			item.useAnimation = 15;   //this is how fast the animation when the item is used
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 4;
			item.value = 10;
			item.rare = ItemRarityID.Green;
			item.reuseDelay = 6;    //this is the item delay
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;       //this make the item auto reuse
			item.shoot = mod.ProjectileType("BloodBoomerangProjectile");
			item.shootSpeed = 11f;     //projectile speed
			item.useTurn = true;
			item.maxStack = 2;       //this is the max stack of this item
			item.consumable = false;  //this make the item consumable when used
			item.noUseGraphic = true;
		}

		public override void AddRecipes()  //How to craft this item
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrimtaneBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}