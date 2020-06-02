using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Consumables
{
	public class MysteriousTablet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Summons Lunatic Cultist");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(8, 4));
		}

		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 20;
			item.maxStack = 999;
			item.rare = ItemRarityID.Blue;
			item.useAnimation = 45;
			item.useTime = 45;
			item.useStyle = ItemUseStyleID.HoldingUp;
			item.UseSound = SoundID.Item15;
			item.consumable = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentStardust, 5);
			recipe.AddIngredient(ItemID.FragmentSolar, 5);
			recipe.AddIngredient(ItemID.FragmentNebula, 5);
			recipe.AddIngredient(ItemID.FragmentVortex, 5);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.CultistBoss);
			return true;
		}
	}
}