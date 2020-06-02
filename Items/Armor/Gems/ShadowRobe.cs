using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Gems
{
	[AutoloadEquip(EquipType.Body)]
	public class ShadowRobe : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Shadow Robe");
			Tooltip.SetDefault("\n+100 Mana, -17% Mana Cost");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 10;
			item.value = 100;
			item.rare = ItemRarityID.Green;
			item.defense = 5;
		}

		public override void UpdateEquip(Player player)
		{
			//player.endurance *= 1.05f;
			//player.statManaMax2 += 20;
			player.statManaMax2 += 100;
			player.manaCost -= 0.17f;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return head.type == ItemID.WizardHat;
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "+60 mana.";
			player.statManaMax2 += 60;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ShadowCrystal", 10);
			recipe.AddIngredient(ItemID.Robe, 1);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}