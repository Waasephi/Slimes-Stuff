using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Lumina
{
	[AutoloadEquip(EquipType.Legs)]
	public class LuminaLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Lumina Leggings");
			Tooltip.SetDefault("+30% Movement Speed" +
				"\n[c/00f2ff:-Spirit Class-]");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 10;
			item.value = 100;
			item.rare = 2;
			item.defense = 23;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed *= 1.3f;
			//player.maxMinions+=2;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "SpiritInfusedBar", 15);
			recipe.AddIngredient(mod, "LuminaFragment", 15);
			recipe.AddIngredient(ItemID.LunarBar, 12);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}