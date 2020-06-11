using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Accessories
{
	public class MoltenShield : ModItem //replace ItemName with the name of your accessory
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Molten Shield");
			Tooltip.SetDefault("For the true Warrior. (+3 Defence, +20 Max Life, Gives Immunity To Chilled Debuff, Obsidian Shield And Magma Stone Buffs)");
		}

		public override void UpdateAccessory(Player player, bool hideVisual) //Where it says "p" is the variable used to represent "player". In this case, every p stands for player. This is called when the accessory is on.
		{
			player.statLifeMax2 += 20;//This is where an effect from the list goes.
			player.fireWalk = true;
			player.noKnockback = true;
			player.magmaStone = true;
			player.statDefense += 3;
			player.buffImmune[BuffID.Chilled] = true;
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.accessory = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ObsidianShield, 1);
			recipe.AddIngredient(ItemID.HellstoneBar, 50);
			recipe.AddIngredient(ItemID.MagmaStone, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}