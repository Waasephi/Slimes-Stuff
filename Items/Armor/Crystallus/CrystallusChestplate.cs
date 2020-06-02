using OurStuffAddon.Items.SpiritDamageClass;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Crystallus
{
	[AutoloadEquip(EquipType.Body)]
	public class CrystallusChestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Crystallus Chestplate");
			Tooltip.SetDefault("+17% [c/00f2ff:Spirit Crit], +8% Endurance" +
				"\n[c/00f2ff:-Spirit Class-]");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 24;
			item.value = 100;
			item.rare = ItemRarityID.Pink;
			item.defense = 10;
		}

		public override void UpdateEquip(Player player)
		{
			SpiritDamagePlayer modPlayer = SpiritDamagePlayer.ModPlayer(player);
			modPlayer.spiritCrit += 17; // add 5% crit
			player.endurance *= 1.08f;
			//player.statManaMax2 += 20;
			//player.maxMinions++;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrystalShard, 20);
			recipe.AddIngredient(mod, "CrystalCore");
			recipe.AddIngredient(ItemID.SoulofLight, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}