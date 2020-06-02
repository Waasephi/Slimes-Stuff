using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Gel
{
	[AutoloadEquip(EquipType.Body)]
	public class GelRobe : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Gel Robe");
			Tooltip.SetDefault("\n+10 Mana, -5% Mana Cost");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 10;
			item.value = 100;
			item.rare = 2;
			item.defense = 3;
		}

		public override void UpdateEquip(Player player)
		{
			//player.endurance *= 1.05f;
			//player.statManaMax2 += 20;
			player.statManaMax2 += 10;
			player.manaCost -= 0.05f;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 100);
			recipe.AddIngredient(ItemID.Silk, 30);
			recipe.AddTile(220);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}