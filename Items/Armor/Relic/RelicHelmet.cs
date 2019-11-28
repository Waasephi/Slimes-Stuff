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

namespace OurStuffAddon.Items.Armor.Relic
{
    [AutoloadEquip(EquipType.Head)]
    public class RelicHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Relic Helmet");
            Tooltip.SetDefault("Increased Thrown Crit");
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
            player.thrownCrit += 7;
            //player.endurance *= 1.05f;
            //player.statManaMax2 += 20;
            //player.maxMinions += 1;
            //player.AddBuff(BuffID.Shine, 2);
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("RelicChestplate") && legs.type == mod.ItemType("RelicGreaves");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "10% Increased Endurance";
            player.endurance *= 1.1f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldHelmet);
            recipe.AddIngredient(mod, "RelicShard", 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}