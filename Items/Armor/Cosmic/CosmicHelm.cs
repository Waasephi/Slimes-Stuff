using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Cosmic
{
	[AutoloadEquip(EquipType.Head)]
	public class CosmicHelm : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Cosmic Helm");
			Tooltip.SetDefault("\n+20 Max Life, +17% Thrown Crit");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 10;
			item.value = 100;
			item.rare = 11;
			item.defense = 20;
		}

		public override void UpdateEquip(Player player)
		{
			//player.endurance *= 1.05f;
			player.statLifeMax2 += 20;
			player.thrownCrit += 17;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("CosmicArmor") && legs.type == mod.ItemType("CosmicCuisses");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increased Life Regen, +40 Max Life.";
			player.lifeRegen += 2;
			player.statLifeMax2 += 40;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 8);
			recipe.AddIngredient(mod, "CosmicFragment", 10);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}