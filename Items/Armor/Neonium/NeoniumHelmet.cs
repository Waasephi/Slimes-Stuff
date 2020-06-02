using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Neonium
{
	[AutoloadEquip(EquipType.Head)]
	public class NeoniumHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Neonium Helmet");
			Tooltip.SetDefault("Increased ranged crit.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 10;
			item.value = 100;
			item.rare = 2;
			item.defense = 8;
		}

		public override void UpdateEquip(Player player)
		{
			//player.endurance *= 1.05f;
			//player.statManaMax2 += 20;
			player.rangedCrit += 7;
			//player.AddBuff(BuffID.Shine, 2);
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("NeoniumChestplate") && legs.type == mod.ItemType("NeoniumLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increased Life Regen, Gives a green glow.";
			player.lifeRegen += 1;
			Lighting.AddLight((int)(player.position.X + (float)(player.width / 2)) / 16, (int)(player.position.Y + (float)(player.height / 2)) / 16, 0f, 2f, 0f);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "NeoniumBar", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}