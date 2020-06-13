using Microsoft.Xna.Framework;
using OurStuffAddon.Projectiles.Minions;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace OurStuffAddon.Items.Summoner
{
	public class TrueSpiritRod : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Summons a true spirit wisp to fight for you.");
			ItemID.Sets.GamepadWholeScreenUseRange[item.type] = true;
			ItemID.Sets.LockOnIgnoresCollision[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.damage = 78;
			item.summon = true;
			item.mana = 10;
			item.width = 26;
			item.height = 28;
			item.useTime = 36;
			item.useAnimation = 36;
			item.useStyle = 1;
			item.noMelee = true;
			item.knockBack = 3;
			item.value = Item.buyPrice(0, 1, 0, 0);
			item.rare = 9;
			item.UseSound = SoundID.Item44;
			item.shoot = ProjectileType<TrueSpiritWisp>();
			item.buffType = BuffType<Buffs.TrueSpiritWisp>(); //The buff added to player after used the item
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			player.AddBuff(item.buffType, 2);
			position = Main.MouseWorld;
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<ChloroRod>());
			recipe.AddIngredient(ModContent.ItemType<SpiritInfusedBar>(), 20);
			recipe.AddTile(mod, "SpiritInfuser");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}