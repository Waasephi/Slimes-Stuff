using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.HMThrown
{
	[AutoloadEquip(EquipType.Head)]
	public class CobaltHeadpiece : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Cobalt Headpiece");
			Tooltip.SetDefault(" 9% Thrown Damage");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 10;
			item.value = 100;
			item.rare = 10;
			item.defense = 7;
		}

		public override void UpdateEquip(Player player)
		{
			//player.endurance *= 1.05f;
			player.thrownDamage *= 1.09f;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == (ItemID.CobaltBreastplate) && legs.type == (ItemID.CobaltLeggings);
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "+12% thrown velocity.";
			player.thrownVelocity *= 1.12f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CobaltBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}