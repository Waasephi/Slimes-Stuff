using OurStuffAddon.NPCs.Bosses;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Consumables
{
	public class GoldenStarMesh : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Summons A Cosmic Amalgamation Infinitely");
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
			recipe.AddIngredient(ModContent.ItemType<CosmicStarMesh>(), 10);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool UseItem(Player player)
		{
			Main.NewText("You think all slimes are pushovers? Please... you havent seen our best.", 200, 0, 250);
			NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<CosmicSlime>());
			return true;
		}
	}
}