using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.SpiritDamageClass
{
	// This class handles everything for our custom damage class
	// Any class that we wish to be using our custom damage class will derive from this class, instead of ModItem

	public class SpiritInfusedEnchantedSword : SpiritDamageItem
	{
		// Called when the mod loads, so our changes are added to the game
		public static void AddHacks()
		{
			// Set ourselves to be ranged temporarily to benefit from ranged bonuses
			// This is needed because terraria changes the variables before calling tML's method
			// based on if the item was set to be ranged. Ours isn't, but we still want our custom bow
			// to benefit from ranged bonuses, despite being an Example damage weapon.
			// This is how to do it.
			On.Terraria.Player.GetWeaponDamage += PlayerOnGetWeaponDamage;
			On.Terraria.Player.GetWeaponKnockback += PlayerOnGetWeaponKnockback;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spirit Infused Enchanted Sword");
			Tooltip.SetDefault("Some magic and holding it differently apparently makes it stronger? Since its still just a sword the blade still does damage." +
				"\n[c/00f2ff:-Spirit Class-]");
			Item.staff[item.type] = true;
		}

		// Our ExampleDamageItem abstract class handles all code related to our custom damage class
		public override void SafeSetDefaults()
		{
			item.shootSpeed = 6f;
			item.shoot = ProjectileID.EnchantedBeam;
			item.UseSound = SoundID.Item1;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = false;
			item.Size = new Vector2(18, 46);
			item.damage = 20;
			item.crit = 2;
			item.knockBack = 2;
			item.autoReuse = true;
			item.rare = ItemRarityID.Cyan;
		}

		public override void GetWeaponCrit(Player player, ref int crit)
		{
			// It is hard to hook into every place checking item's crit and fake item.ranged = true
			// Instead, we can mimick regular ranged crit assignment
			crit = Main.LocalPlayer.rangedCrit - Main.LocalPlayer.inventory[Main.LocalPlayer.selectedItem].crit + Main.HoverItem.crit;
			base.GetWeaponCrit(player, ref crit);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SpiriciteCrystal>(), 10);
			recipe.AddIngredient(ItemID.EnchantedSword);
			recipe.AddTile(mod, "SpiritInfuser");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		private static float PlayerOnGetWeaponKnockback(On.Terraria.Player.orig_GetWeaponKnockback orig, Player self, Item sitem, float knockback)
		{
			bool isSpiritCaster = sitem.type == ModContent.ItemType<SpiritInfusedEnchantedSword>();
			if (isSpiritCaster) sitem.ranged = true;

			float kb = orig(self, sitem, knockback);
			if (isSpiritCaster) sitem.ranged = false;
			return kb;
		}

		private static int PlayerOnGetWeaponDamage(On.Terraria.Player.orig_GetWeaponDamage orig, Player self, Item sitem)
		{
			bool isSpiritCaster = sitem.type == ModContent.ItemType<SpiritInfusedEnchantedSword>();
			if (isSpiritCaster) sitem.ranged = true;

			int dmg = orig(self, sitem);
			if (isSpiritCaster) sitem.ranged = false;
			return dmg;
		}
	}
}