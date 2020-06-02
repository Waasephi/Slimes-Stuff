using OurStuffAddon.Items.SpiritDamageClass;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Fenlian
{
	[AutoloadEquip(EquipType.Head)]
	public class FenlianCrown : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Fenlian Crown");
			Tooltip.SetDefault("+19% [c/00f2ff:Spirit Damage]" +
				"\n[c/00f2ff:-Spirit Class-]");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 10;
			item.value = 100;
			item.rare = ItemRarityID.Lime;
			item.defense = 14;
		}

		public override void UpdateEquip(Player player)
		{
			SpiritDamagePlayer modPlayer = SpiritDamagePlayer.ModPlayer(player);
			//player.endurance *= 1.05f;
			//player.statManaMax2 += 20;
			modPlayer.spiritDamageMult *= 1.19f; // add 20% to the multiplicative bonus
												 //player.AddBuff(BuffID.Shine, 2);
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("FenlianArmor") && legs.type == mod.ItemType("FenlianBoots");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Chlorophyte Armor Set Bonus, +2 Defence, +14% [c/00f2ff:Spirit Damage].";
			player.statDefense += 2;
			SpiritDamagePlayer modPlayer = SpiritDamagePlayer.ModPlayer(player);
			modPlayer.spiritDamageMult *= 1.14f;
			player.AddBuff(BuffID.LeafCrystal, 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}