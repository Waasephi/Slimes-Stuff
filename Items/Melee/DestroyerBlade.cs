using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Melee
{
	public class DestroyerBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Destroyer Blade");
			Tooltip.SetDefault("-Cheat Weapon-");
		}

		public override void SetDefaults()
		{
			item.damage = 9999;
			item.melee = true;
			item.width = 80;
			item.height = 80;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 1;
			item.knockBack = 6;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}