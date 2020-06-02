using OurStuffAddon.Items.SpiritDamageClass;
using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;
using Terraria.ID;

namespace OurStuffAddon.Items.Accessories
{
	public class RainbowCharm : ModItem //replace ItemName with the name of your accessory
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rainbow Charm");
			Tooltip.SetDefault("Gives slightly weaker effects of all charms without the downsides.");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(8, 8));
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.dash = 2;
			player.maxMinions += 1;
			player.magicDamage += .1f;
			player.meleeDamage += .1f;
			player.rangedDamage += .1f;
			player.thrownDamage += .1f;
			player.pickSpeed += .1f;
			SpiritDamagePlayer modPlayer = SpiritDamagePlayer.ModPlayer(player);
			modPlayer.spiritDamageMult += .1f;
			player.detectCreature = true;
			player.dangerSense = true;
			player.findTreasure = true;
			Lighting.AddLight((int)(player.position.X + player.width / 2) / 16, (int)(player.position.Y + player.height / 2) / 16, 0.8f, 0.95f, 1f);
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.accessory = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DashCharm");
			recipe.AddIngredient(mod, "NinjaCharm");
			recipe.AddIngredient(mod, "MinerCharm");
			recipe.AddIngredient(mod, "WizardCharm");
			recipe.AddIngredient(mod, "SummonerCharm");
			recipe.AddIngredient(mod, "WarriorCharm");
			recipe.AddIngredient(mod, "RangerCharm");
			recipe.AddIngredient(mod, "SpiricistCharm");
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}