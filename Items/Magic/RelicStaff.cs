using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Magic
{
	public class RelicStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Relic Staff");
			Item.staff[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 20;
			item.magic = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 100;
			item.rare = -1;
			item.UseSound = SoundID.Item43;
			item.autoReuse = true;
			item.shoot = 126;
			item.shootSpeed = 6f;
			item.mana = 5;
			item.noMelee = true;
		}
	}
}