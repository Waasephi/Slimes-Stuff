using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Melee
{
	public class SiftersTooth : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sifter's Tooth");
		}

		public override void SetDefaults()
		{
			item.damage = 14;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("SifterToothProjectile");
			item.shootSpeed = 6f;
		}
	}
}