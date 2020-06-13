using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Accessories
{
	public class MoltenAnkhShield : ModItem //replace ItemName with the name of your accessory
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Molten Ankh Shield");
			Tooltip.SetDefault("For the true fighter. (+6 Defence, +60 Max Life, Ankh Shield, Immunity To Lava, Immunity To Frozen Debuff, And Magma Shield Buffs)");
		}

		public override void UpdateAccessory(Player player, bool hideVisual) //Where it says "p" is the variable used to represent "player". In this case, every p stands for player. This is called when the accessory is on.
		{
			player.statLifeMax2 += 60; //This is where an effect from the list goes.
			player.fireWalk = true;
			player.noKnockback = true;
			player.magmaStone = true;
			player.statDefense += 6;
			player.lavaImmune = true;
			player.buffImmune[BuffID.Cursed] = true;
			player.buffImmune[BuffID.Weak] = true;
			player.buffImmune[BuffID.Slow] = true;
			player.buffImmune[BuffID.Confused] = true;
			player.buffImmune[BuffID.BrokenArmor] = true;
			player.buffImmune[BuffID.Silenced] = true;
			player.buffImmune[BuffID.Poisoned] = true;
			player.buffImmune[BuffID.Chilled] = true;
			player.buffImmune[BuffID.Darkness] = true;
			player.buffImmune[BuffID.Bleeding] = true;
			player.buffImmune[BuffID.Frozen] = true;
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 60;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.accessory = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AnkhCharm);
			recipe.AddIngredient(ModContent.ItemType<MoltenShield>());
			recipe.AddIngredient(ItemID.ObsidianRose);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}