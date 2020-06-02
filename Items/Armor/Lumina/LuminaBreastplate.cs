using OurStuffAddon.Items.SpiritDamageClass;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Lumina
{
	[AutoloadEquip(EquipType.Body)]
	public class LuminaBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Lumina Breastplate");
			Tooltip.SetDefault("+30% [c/00f2ff:Spirit Crit]" +
				"\n[c/00f2ff:-Spirit Class-]");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 24;
			item.value = 100;
			item.rare = 2;
			item.defense = 25;
		}

		public override void UpdateEquip(Player player)
		{
			SpiritDamagePlayer modPlayer = SpiritDamagePlayer.ModPlayer(player);
			modPlayer.spiritCrit += 30; // add 5% crit
										//player.statManaMax2 += 20;
										//player.maxMinions++;
										//player.AddBuff(BuffID.Shine, 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "SpiritInfusedBar", 20);
			recipe.AddIngredient(mod, "LuminaFragment", 20);
			recipe.AddIngredient(ItemID.LunarBar, 16);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}