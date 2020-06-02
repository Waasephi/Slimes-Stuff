using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Sky
{
	[AutoloadEquip(EquipType.Legs)]
	public class SkyLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Sky Leggings");
			Tooltip.SetDefault("+10% Movement Speed");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 10;
			item.value = 100;
			item.rare = ItemRarityID.Green;
			item.defense = 5;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed *= 1.1f;
			//player.statManaMax2 += 20;
			//player.maxMinions+=2;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("SkyEssence"), 15);
			recipe.AddTile(TileID.SkyMill);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}