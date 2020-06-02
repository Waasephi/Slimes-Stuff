using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Throwing
{
	public class RelicChakram : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Relic Chakram");
		}

		public override void SetDefaults()
		{
			item.damage = 30;
			item.thrown = true;
			item.width = 30;
			item.height = 30;
			item.useTime = 25;
			item.useAnimation = 25;
			item.noUseGraphic = true;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 3;
			item.value = 8;
			item.rare = -1;
			item.shootSpeed = 12f;
			item.shoot = mod.ProjectileType("RelicChakramProjectile");
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}