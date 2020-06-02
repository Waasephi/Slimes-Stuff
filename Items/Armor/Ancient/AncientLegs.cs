using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Ancient
{
	[AutoloadEquip(EquipType.Legs)]
	public class AncientLegs : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Ancient Legs");
			Tooltip.SetDefault("\n+15 %Movement Speed, +25% Thrown Velocity");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 10;
			item.value = 100;
			item.rare = ItemRarityID.Purple;
			item.defense = 18;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed *= 1.15f;
			player.thrownVelocity += .25f;
			//player.maxMinions+=2;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LihzahrdBrick, 65);
			recipe.AddIngredient(mod, "SolarPebble", 15);
			recipe.AddTile(TileID.LihzahrdFurnace);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}