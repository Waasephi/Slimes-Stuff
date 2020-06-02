using OurStuffAddon.Items.SpiritDamageClass;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Magmatic
{
	[AutoloadEquip(EquipType.Head)]
	public class MagmaticMask : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Magmatic Mask");
			Tooltip.SetDefault("+18% [c/00f2ff:Spirit Damage]" +
				"\n[c/00f2ff:-Spirit Class-]");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 10;
			item.value = 100;
			item.rare = ItemRarityID.Red;
			item.defense = 10;
		}

		public override void UpdateEquip(Player player)
		{
			SpiritDamagePlayer modPlayer = SpiritDamagePlayer.ModPlayer(player);
			//player.endurance *= 1.05f;
			//player.statManaMax2 += 20;
			modPlayer.spiritDamageMult *= 1.18f; // add 20% to the multiplicative bonus
												 //player.AddBuff(BuffID.Shine, 2);
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("MagmaticArmor") && legs.type == mod.ItemType("MagmaticBoots");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "+22% [c/00f2ff:Spirit Damage].";
			SpiritDamagePlayer modPlayer = SpiritDamagePlayer.ModPlayer(player);
			modPlayer.spiritDamageMult *= 1.22f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AshBlock, 50);
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}