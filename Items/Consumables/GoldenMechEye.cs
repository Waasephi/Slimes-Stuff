using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Consumables
{
	public class GoldenMechEye : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Summons Twins Infinitely");
		}

		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 20;
			item.maxStack = 1;
			item.rare = ItemRarityID.Blue;
			item.useAnimation = 45;
			item.useTime = 45;
			item.useStyle = ItemUseStyleID.HoldingUp;
			item.UseSound = SoundID.Item15;
			item.consumable = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MechanicalEye, 10);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.Retinazer);
			NPC.SpawnOnPlayer(player.whoAmI, NPCID.Spazmatism);
			return true;
		}
	}
}