using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Dark
{
	[AutoloadEquip(EquipType.Head)]
	public class DarkMask : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Dark Mask");
			Tooltip.SetDefault("Increased Melee Crit");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 10;
			item.value = 100;
			item.rare = 2;
			item.defense = 8;
		}

		public override void UpdateEquip(Player player)
		{
			player.meleeCrit += 10;
			//player.endurance *= 1.05f;
			//player.statManaMax2 += 20;
			//player.maxMinions += 1;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("DarkPlate") && legs.type == mod.ItemType("DarkLegs");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "15% Increased Melee Damage";
			player.meleeDamage *= 1.15f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("DarkSteel"), 10);
			recipe.AddTile(26);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}