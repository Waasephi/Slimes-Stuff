using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Throwing
{
	public class Relicarver : ModItem

	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Relicarver");
		}

		public override void SetDefaults()
		{
			item.damage = 25;           //this is the item damage
			item.thrown = true;             //this make the item do throwing damage
			item.noMelee = true;
			item.width = 21;
			item.height = 30;
			item.useTime = 10;       //this is how fast you use the item
			item.useAnimation = 10;   //this is how fast the animation when the item is used
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 4;
			item.value = 10;
			item.rare = -1;
			item.reuseDelay = 3;    //this is the item delay
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;       //this make the item auto reuse
			item.shoot = mod.ProjectileType("RelicarverProjectile");
			item.shootSpeed = 10f;     //projectile speed
			item.useTurn = true;
			item.maxStack = 1;       //this is the max stack of this item
			item.consumable = false;  //this make the item consumable when used
			item.noUseGraphic = true;
		}
	}
}