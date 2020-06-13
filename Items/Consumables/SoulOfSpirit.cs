using OurStuffAddon.Buffs;
using OurStuffAddon.Items.Materials;
using OurStuffAddon.Projectiles.Pets;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Consumables
{
	public class SoulOfSpirit : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName and Tooltip are automatically set from the .lang files, but below is how it is done normally.
			DisplayName.SetDefault("Soul of Spirit");
			Tooltip.SetDefault("Summons an innocent spirit.");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(4, 4));
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.Carrot);
			item.shoot = ModContent.ProjectileType<SpiritPetProjectile>();
			item.buffType = ModContent.BuffType<SpiritPetBuff>();
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
			recipe.AddIngredient(ModContent.ItemType<SpiritShard>(), 50);
			recipe.AddTile(mod, "SpiritInfuser");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}