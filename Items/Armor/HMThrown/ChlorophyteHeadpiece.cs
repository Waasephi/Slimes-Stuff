using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.HMThrown
{
	[AutoloadEquip(EquipType.Head)]
	public class ChlorophyteHeadpiece : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Chlorophyte Headpiece");
			Tooltip.SetDefault(" 16% Thrown Damage");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 10;
			item.value = 100;
			item.rare = ItemRarityID.Red;
			item.defense = 20;
		}

		public override void UpdateEquip(Player player)
		{
			//player.endurance *= 1.05f;
			player.thrownDamage *= 1.16f;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ItemID.ChlorophytePlateMail && legs.type == ItemID.ChlorophyteGreaves;
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Summons a powerful leaf crystal to shoot at nearby enemies.";
			player.AddBuff(BuffID.LeafCrystal, 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 12);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}