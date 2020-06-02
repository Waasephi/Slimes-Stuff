using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Glacial
{
	[AutoloadEquip(EquipType.Legs)]
	public class GlacialLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Glacial Leggings");
			Tooltip.SetDefault("+10% Movement Speed" +
				"\n[c/00f2ff:-Spirit Class-]");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 10;
			item.value = 100;
			item.rare = ItemRarityID.Cyan;
			item.defense = 5;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed *= 1.1f;
			//player.maxMinions+=2;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "GlacialCrystal", 15);
			recipe.AddTile(TileID.IceMachine);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}