using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Consumables.Potions
{
	public class LuminescentPotion : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Gives a strong glow. \n5 minute duration.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 26;
			item.useStyle = ItemUseStyleID.EatingUsing;
			item.useAnimation = 17;
			item.useTime = 17;
			item.useTurn = true;
			item.UseSound = SoundID.Item3;
			item.maxStack = 30;
			item.consumable = true;
			item.rare = 3;
			item.value = Item.buyPrice(gold: 1);
			item.buffType = mod.BuffType("LuminescentGlow");
			item.buffTime = 18000;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "SeafoamCrystal", 5);
			recipe.AddIngredient(ItemID.ShinePotion, 1);
			recipe.AddTile(13);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}