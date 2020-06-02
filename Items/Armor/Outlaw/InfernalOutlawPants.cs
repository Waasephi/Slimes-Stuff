using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Outlaw
{
	[AutoloadEquip(EquipType.Legs)]
	public class InfernalOutlawPants : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Infernal Outlaw Pants");
			Tooltip.SetDefault("\n+10 %Movement Speed, +15% Thrown Velocity");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 10;
			item.value = 100;
			item.rare = 10;
			item.defense = 6;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed *= 1.10f;
			player.thrownVelocity += .15f;
			//player.maxMinions+=2;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(3268);
			recipe.AddIngredient(ItemID.HellstoneBar, 15);
			recipe.AddTile(TileID.Loom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}