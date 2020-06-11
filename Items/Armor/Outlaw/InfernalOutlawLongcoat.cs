using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Outlaw
{
	[AutoloadEquip(EquipType.Body)]
	public class InfernalOutlawLongcoat : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Infernal Outlaw Longcoat");
			Tooltip.SetDefault("+7% Thrown Damage, +10 Max Life");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 24;
			item.value = 100;
			item.rare = ItemRarityID.Red;
			item.defense = 7;
		}

		public override void UpdateEquip(Player player)
		{
			player.thrownDamage *= 1.07f;
			player.statLifeMax2 += 10;
			//player.maxMinions++;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 20);
			recipe.AddIngredient(ItemID.ObsidianShirt);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}