using OurStuffAddon.Items.Materials;
using OurStuffAddon.NPCs.Bosses;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Consumables
{
	public class CosmicStarMesh : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Summons A Cosmic Amalgamation");
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
			//item.shoot = ModContent.ProjectileType<CosmicSlimeSpawn>(); TODO non existant
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 5);
			recipe.AddIngredient(ModContent.ItemType<CosmicFragment>(), 10);
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