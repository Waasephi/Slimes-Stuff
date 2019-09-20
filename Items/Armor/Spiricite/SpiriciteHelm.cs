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

namespace OurStuffAddon.Items.Armor.Spiricite
{
    [AutoloadEquip(EquipType.Head)]
    public class SpiriciteHelm : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Spiricite Helm");
            Tooltip.SetDefault("+5% [c/00f2ff:Spirit Damage]" +
                "\n[c/00f2ff:-Spirit Class-]");
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
            SpiritDamagePlayer modPlayer = SpiritDamagePlayer.ModPlayer(player);
            //player.endurance *= 1.05f;
            //player.statManaMax2 += 20;
            modPlayer.spiritDamageMult *= 1.05f; // add 20% to the multiplicative bonus
            //player.AddBuff(BuffID.Shine, 2);
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("SpiriciteBreastplate") && legs.type == mod.ItemType("SpiriciteShoes");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Increased Life Regen, +2 Defence.";
            player.lifeRegen += 1;
            player.statDefense += 2;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "SpiriciteCrystal", 10);
            recipe.AddTile(mod, "SpiritInfuser");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}