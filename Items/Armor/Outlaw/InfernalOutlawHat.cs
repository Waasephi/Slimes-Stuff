using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Outlaw
{
	[AutoloadEquip(EquipType.Head)]
	public class InfernalOutlawHat : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Infernal Outlaw Hat");
			Tooltip.SetDefault("\n+10 Max Life, +7% Thrown Crit");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 10;
			item.value = 100;
			item.rare = 10;
			item.defense = 6;
		}

		public override void UpdateEquip(Player player)
		{
			//player.endurance *= 1.05f;
			player.statLifeMax2 += 10;
			player.thrownCrit += 7;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("InfernalOutlawLongcoat") && legs.type == mod.ItemType("InfernalOutlawPants");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increased Life Regen, +20 Max Life, +5% Throwing Damage.";
			player.lifeRegen += 1;
			player.thrownDamage *= 1.05f;
			player.statLifeMax2 += 20;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(3266);
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}