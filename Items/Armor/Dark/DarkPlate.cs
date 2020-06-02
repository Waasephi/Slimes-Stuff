using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Dark
{
	[AutoloadEquip(EquipType.Body)]
	public class DarkPlate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Dark Plate");
			Tooltip.SetDefault("+8% Melee Damage");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 24;
			item.value = 100;
			item.rare = 2;
			item.defense = 8;
		}

		public override void UpdateEquip(Player player)
		{
			player.meleeDamage *= 1.08f;
			//player.statManaMax2 += 20;
			//player.maxMinions++;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("DarkSteel"), 20);
			recipe.AddTile(26);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}