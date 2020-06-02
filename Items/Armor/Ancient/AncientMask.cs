using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Ancient
{
	[AutoloadEquip(EquipType.Head)]
	public class AncientMask : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Ancient Mask");
			Tooltip.SetDefault("\n+15% Thrown Crit");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 10;
			item.value = 100;
			item.rare = 11;
			item.defense = 15;
		}

		public override void UpdateEquip(Player player)
		{
			//player.endurance *= 1.05f;
			player.thrownCrit += 15;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("AncientArmor") && legs.type == mod.ItemType("AncientLegs");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Greatly Increased Life Regen, +20 Max Life, Increased Thrown Damage.";
			player.lifeRegen += 4;
			player.statLifeMax2 += 20;
			player.thrownDamage *= 1.11f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LihzahrdBrick, 35);
			recipe.AddIngredient(mod, "SolarPebble", 10);
			recipe.AddTile(303);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}