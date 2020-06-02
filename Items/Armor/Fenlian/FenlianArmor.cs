using OurStuffAddon.Items.SpiritDamageClass;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Fenlian
{
	[AutoloadEquip(EquipType.Body)]
	public class FenlianArmor : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Fenlian Armor");
			Tooltip.SetDefault("+19% [c/00f2ff:Spirit Crit], +10% Endurance" +
				"\n[c/00f2ff:-Spirit Class-]");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 24;
			item.value = 100;
			item.rare = ItemRarityID.Lime;
			item.defense = 15;
		}

		public override void UpdateEquip(Player player)
		{
			SpiritDamagePlayer modPlayer = SpiritDamagePlayer.ModPlayer(player);
			modPlayer.spiritCrit += 19; // add 5% crit
			player.endurance *= 1.1f;
			//player.statManaMax2 += 20;
			//player.maxMinions++;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 20);
			recipe.AddIngredient(mod, "LivingMush");
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}