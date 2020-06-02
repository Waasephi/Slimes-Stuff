using OurStuffAddon.Items.SpiritDamageClass;
using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Spiricite
{
	[AutoloadEquip(EquipType.Body)]
	public class SpiriciteBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Spiricite Beastplate");
			Tooltip.SetDefault("+5% [c/00f2ff:Spirit Crit]" +
				"\n[c/00f2ff:-Spirit Class-]");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 24;
			item.value = 100;
			item.rare = 2;
			item.defense = 3;
		}

		public override void UpdateEquip(Player player)
		{
			SpiritDamagePlayer modPlayer = SpiritDamagePlayer.ModPlayer(player);
			modPlayer.spiritCrit += 5; // add 5% crit
									   //player.statManaMax2 += 20;
									   //player.maxMinions++;
									   //player.AddBuff(BuffID.Shine, 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "SpiriciteCrystal", 20);
			recipe.AddTile(mod, "SpiritInfuser");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}