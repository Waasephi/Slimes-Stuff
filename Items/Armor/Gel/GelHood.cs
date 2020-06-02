using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Gel
{
	[AutoloadEquip(EquipType.Head)]
	public class GelHood : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Gel Hood");
			Tooltip.SetDefault("\n+10 Mana");
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
			player.statManaMax2 += 10;
			//player.maxMinions += 1;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("GelRobe");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "5% Increased Magic Damage";
			player.magicDamage += 0.05f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 50);
			recipe.AddIngredient(ItemID.Silk, 20);
			recipe.AddTile(220);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}