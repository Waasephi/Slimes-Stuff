using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.SandScale
{
	[AutoloadEquip(EquipType.Head)]
	public class SandScaleHelm : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Sand Scale Helm");
			Tooltip.SetDefault("\n+2 Minions");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 10;
			item.value = 100;
			item.rare = 2;
			item.defense = 3;
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
			return body.type == mod.ItemType("SandScalemail") && legs.type == mod.ItemType("SandScaleBoots");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = " Gives Creature Detection.";
			player.detectCreature = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "SandSifterMandible", 5);
			recipe.AddIngredient(mod, "SandSifterScale", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}