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

namespace OurStuffAddon.Items.Armor.SpiritRobe
{
    [AutoloadEquip(EquipType.Head)]
    public class SpiritHood : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Spirit Hood");
            Tooltip.SetDefault("+20% [c/00f2ff:Spirit Damage]" +
                "\n[c/00f2ff:-Spirit Class-]");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 10;
            item.value = 100;
            item.rare = 2;
            item.defense = 16;
        }

        public override void UpdateEquip(Player player)
        {
            SpiritDamagePlayer modPlayer = SpiritDamagePlayer.ModPlayer(player);
            //player.endurance *= 1.05f;
            //player.statManaMax2 += 20;
            modPlayer.spiritDamageMult *= 1.2f; // add 20% to the multiplicative bonus
            //player.AddBuff(BuffID.Shine, 2);
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("SpiritRobe") && legs.type == mod.ItemType("SpiritPants");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Greatly Increased Life Regen, +8 Defence, +12% [c/00f2ff:Spirit Damage].";
            player.lifeRegen += 3;
            player.statDefense += 8;
            SpiritDamagePlayer modPlayer = SpiritDamagePlayer.ModPlayer(player);
            modPlayer.spiritDamageMult *= 1.12f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "SpiritInfusedBar", 10);
            recipe.AddTile(mod, "SpiritInfuser");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}