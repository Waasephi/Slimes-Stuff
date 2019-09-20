using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader.IO;
using Terraria.DataStructures;
using Terraria.GameInput;
using OurStuffAddon.Items.SpiritDamageClass;

namespace OurStuffAddon.Items.Armor.Lumina
{
    [AutoloadEquip(EquipType.Head)]
    public class LuminaMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Lumina Mask");
            Tooltip.SetDefault("+25% [c/00f2ff:Spirit Damage]" +
                "\n[c/00f2ff:-Spirit Class-]");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 10;
            item.value = 100;
            item.rare = 2;
            item.defense = 18;
        }

        public override void UpdateEquip(Player player)
        {
            SpiritDamagePlayer modPlayer = SpiritDamagePlayer.ModPlayer(player);
            //player.endurance *= 1.05f;
            //player.statManaMax2 += 20;
            modPlayer.spiritDamageMult *= 1.25f; // add 20% to the multiplicative bonus
            //player.AddBuff(BuffID.Shine, 2);
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("LuminaBreastplate") && legs.type == mod.ItemType("LuminaLeggings");
        }

        public override void UpdateArmorSet(Player player)
        {
            SpiritDamagePlayer modPlayer = SpiritDamagePlayer.ModPlayer(player);
            player.setBonus = "Immensely Increased Life Regen, +10% [c/00f2ff:Spirit Damage].";
            player.lifeRegen += 5;
            modPlayer.spiritDamageMult *= 1.1f; // add 20% to the multiplicative bonus
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "SpiritInfusedBar", 10);
            recipe.AddIngredient(ItemID.LunarBar, 8);
            recipe.AddIngredient(mod, "LuminaFragment", 10);
            recipe.AddTile(412);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}