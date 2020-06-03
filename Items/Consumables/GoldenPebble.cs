using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Consumables
{
	public class GoldenPebble : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Summons An Ancient Beast Infinitely, Must Be Used In The Ruin");
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
			item.consumable = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "RelicPebble", 10);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool CanUseItem(Player player)
		{
			return player.GetModPlayer<MyPlayer>().ZoneRuin;
		}

		public override bool UseItem(Player player)
		{
			if (MyWorld.downedAncientObserver == true)
			{
				Main.NewText("Why do you do this to the creatures of this world?", 70, 70, 0);
			}
			else
				Main.NewText("*Unintelligible Screeching*", 70, 70, 0);
			NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<AncientObserver>());
			return true;
		}
	}
}