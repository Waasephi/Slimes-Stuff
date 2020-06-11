using OurStuffAddon.Items.SpiritDamageClass;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Aquatic
{
	[AutoloadEquip(EquipType.Head)]
	public class AquaticBubble : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Aquatic Bubble");
			Tooltip.SetDefault("+9% [c/00f2ff:Spirit Damage]" +
				"\n[c/00f2ff:-Spirit Class-]");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 10;
			item.value = 100;
			item.rare = ItemRarityID.Cyan;
			item.defense = 13;
		}

		public override void UpdateEquip(Player player)
		{
			SpiritDamagePlayer modPlayer = SpiritDamagePlayer.ModPlayer(player);
			//player.endurance *= 1.05f;
			//player.statManaMax2 += 20;
			modPlayer.spiritDamageMult *= 1.09f; // add 20% to the multiplicative bonus
												 //player.AddBuff(BuffID.Shine, 2);
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<AquaticPlate>() && legs.type == ModContent.ItemType<AquaticBoots>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "+6 Defence, +7% [c/00f2ff:Spirit Damage].";
			player.statDefense += 6;
			SpiritDamagePlayer modPlayer = SpiritDamagePlayer.ModPlayer(player);
			modPlayer.spiritDamageMult *= 1.07f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Coral, 20);
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}