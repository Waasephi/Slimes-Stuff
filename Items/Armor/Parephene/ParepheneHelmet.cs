using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Parephene
{
	[AutoloadEquip(EquipType.Head)]
	public class ParepheneHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Parephene Helmet");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 10;
			item.value = 100;
			item.rare = 2;
			item.defense = 13;
		}

		public override void UpdateEquip(Player player)
		{
			//player.endurance *= 1.05f;
			//player.statManaMax2 += 20;
			//player.maxMinions += 1;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("ParepheneChestplate") && legs.type == mod.ItemType("ParepheneLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "+6 Defence";
			player.statDefense += 6;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ParepheneBar", 10);
			recipe.AddTile(134);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}