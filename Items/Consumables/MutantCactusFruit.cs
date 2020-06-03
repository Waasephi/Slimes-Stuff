using OurStuffAddon.Buffs;
using OurStuffAddon.Projectiles.Pets;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Consumables
{
	public class MutantCactusFruit : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName and Tooltip are automatically set from the .lang files, but below is how it is done normally.
			DisplayName.SetDefault("Mutant Cactus Fruit");
			Tooltip.SetDefault("Grows a small cactus.");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Carrot);
			item.shoot = ModContent.ProjectileType<BabyCactusProjectile>();
			item.buffType = ModContent.BuffType<BabyCactusBuff>();
		}

		public override void UseStyle(Player player)
		{
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
			{
				player.AddBuff(item.buffType, 3600, true);
			}
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Cactus, 100);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}