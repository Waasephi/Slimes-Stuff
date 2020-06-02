using OurStuffAddon.Items.SpiritDamageClass;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Felmar
{
	[AutoloadEquip(EquipType.Head)]
	public class FelmarHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Felmar Helmet");
			Tooltip.SetDefault("+11% [c/00f2ff:Spirit Damage]" +
				"\n[c/00f2ff:-Spirit Class-]");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 10;
			item.value = 100;
			item.rare = ItemRarityID.Yellow;
			item.defense = 7;
		}

		public override void UpdateEquip(Player player)
		{
			SpiritDamagePlayer modPlayer = SpiritDamagePlayer.ModPlayer(player);
			//player.endurance *= 1.05f;
			//player.statManaMax2 += 20;
			modPlayer.spiritDamageMult *= 1.11f; // add 20% to the multiplicative bonus
												 //player.AddBuff(BuffID.Shine, 2);
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("FelmarBodypiece") && legs.type == mod.ItemType("FelmarCuisses");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increased Life Regen, +5 Defence, +13% [c/00f2ff:Spirit Damage].";
			player.lifeRegen += 1;
			player.statDefense += 5;
			SpiritDamagePlayer modPlayer = SpiritDamagePlayer.ModPlayer(player);
			modPlayer.spiritDamageMult *= 1.13f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddIngredient(ItemID.SandBlock, 50);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}