using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Ranged.Ammo
{
	public class NeoEnergyPouch : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Neo Energy Pouch");
		}

		public override void SetDefaults()
		{
			item.damage = 5;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 1;
			item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 1.5f;
			item.value = 1;
			item.expert = true;
			item.rare = ItemRarityID.Blue;
			item.shoot = mod.ProjectileType("NeonBullet");   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 16f;                  //The speed of the projectile
			item.ammo = AmmoID.Bullet;              //The ammo class this ammo belongs to.
		}
	}
}