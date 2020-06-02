using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Summoner
{
	//imported from my tAPI mod because I'm lazy
	public class BlueSlimeStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Summons a blue slime to fight for you." +
					 "        [c/debe00:Rare Weapon!]");
		}

		public override void SetDefaults()
		{
			item.damage = 15;
			item.summon = true;
			item.mana = 8;
			item.width = 26;
			item.height = 28;
			item.useTime = 36;
			item.useAnimation = 36;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.noMelee = true;
			item.knockBack = 1;
			item.value = Item.buyPrice(0, 3, 0, 0);
			item.rare = -12;
			item.UseSound = SoundID.Item44;
			item.shoot = mod.ProjectileType("BlueSlime");
			item.shootSpeed = 10f;
			item.buffType = mod.BuffType("BlueSlime"); //The buff added to player after used the item
			item.buffTime = 3600;               //The duration of the buff, here is 60 seconds
		}

		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			return player.altFunctionUse != 2;
		}

		public override bool UseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				player.MinionNPCTargetAim();
			}
			return base.UseItem(player);
		}
	}
}