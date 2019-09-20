using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Melee
{
	public class ReaperScythe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Reaper Scythe");
		}
		public override void SetDefaults()
		{
			item.damage = 30;
			item.melee = true;
			item.width = 48;
			item.height = 48;
			item.useTime = 25;
			item.useAnimation = 25;
            item.shoot = 274;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item71;
			item.autoReuse = true;
            item.shootSpeed = 6f;
        }
	}
}
