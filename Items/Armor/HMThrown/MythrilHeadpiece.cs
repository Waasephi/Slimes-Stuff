using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.HMThrown
{
	[AutoloadEquip(EquipType.Head)]
	public class MythrilHeadpiece : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Mythril Headpiece");
			Tooltip.SetDefault(" 11% Thrown Damage");
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
			//player.endurance *= 1.05f;
			player.thrownDamage *= 1.11f;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ItemID.MythrilChainmail && legs.type == ItemID.MythrilGreaves;
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "+15% thrown velocity.";
			player.thrownVelocity *= 1.15f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MythrilBar, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}