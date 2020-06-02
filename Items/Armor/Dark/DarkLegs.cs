using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Items.Armor.Dark
{
	[AutoloadEquip(EquipType.Legs)]
	public class DarkLegs : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Dark Legs");
			Tooltip.SetDefault("+15% Movement Speed");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 10;
			item.value = 100;
			item.rare = ItemRarityID.Green;
			item.defense = 8;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed *= 1.5f;
			//player.statManaMax2 += 20;
			//player.maxMinions+=2;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("DarkSteel"), 15);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}