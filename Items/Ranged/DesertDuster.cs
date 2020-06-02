using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Ranged
{
	public class DesertDuster : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Desert Duster");
		}

		public override void SetDefaults()
		{
			item.damage = 20;
			item.ranged = true;
			item.width = 40;
			item.height = 22;
			item.useTime = 23;
			item.useAnimation = 23;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 4;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item41;
			item.autoReuse = true;
			item.shoot = ProjectileID.PurificationPowder;    //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 13f;
			item.useAmmo = AmmoID.Bullet;
		}
	}
}