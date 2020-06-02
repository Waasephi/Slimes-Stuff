using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Ancient
{
	[AutoloadEquip(EquipType.Body)]
	public class AncientArmor : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Ancient Armor");
			Tooltip.SetDefault("+20% Thrown Damage");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 24;
			item.value = 100;
			item.rare = ItemRarityID.Purple;
			item.defense = 23;
		}

		public override void UpdateEquip(Player player)
		{
			player.thrownDamage += 0.2f;
			//player.maxMinions++;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LihzahrdBrick, 100);
			recipe.AddIngredient(mod, "SolarPebble", 25);
			recipe.AddTile(TileID.LihzahrdFurnace);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}