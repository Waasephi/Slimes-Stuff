using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Luminescent
{
	[AutoloadEquip(EquipType.Head)]
	public class LuminescentHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Luminescent Helmet");
			Tooltip.SetDefault("\n+2 Minions");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 10;
			item.value = 100;
			item.rare = 2;
			item.defense = 4;
		}

		public override void UpdateEquip(Player player)
		{
			//player.endurance *= 1.05f;
			//player.statManaMax2 += 20;
			player.maxMinions += 2;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("LuminescentChestplate") && legs.type == mod.ItemType("LuminescentLegs");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Gives Flippers And Gills Buffs, Gives a dim glow.";
			player.AddBuff(BuffID.Gills, 2);
			player.AddBuff(BuffID.Flipper, 2);
			Lighting.AddLight((int)(player.position.X + (float)(player.width / 2)) / 16, (int)(player.position.Y + (float)(player.height / 2)) / 16, 0f, 2f, 1f);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "SeafoamScale", 15);
			recipe.AddIngredient(mod, "SeafoamCrystal", 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}