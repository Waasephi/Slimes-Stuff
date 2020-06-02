using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Cosmic
{
	[AutoloadEquip(EquipType.Body)]
	public class CosmicArmor : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Cosmic Armor");
			Tooltip.SetDefault("+22% Thrown Damage, +20 Max Life");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 24;
			item.value = 100;
			item.rare = ItemRarityID.Purple;
			item.defense = 29;
		}

		public override void UpdateEquip(Player player)
		{
			player.thrownDamage += 0.22f;
			player.statLifeMax2 += 20;
			//player.maxMinions++;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 16);
			recipe.AddIngredient(mod, "CosmicFragment", 20);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}