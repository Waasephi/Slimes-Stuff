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

namespace OurStuffAddon.Items.Armor.Trenagon
{
    [AutoloadEquip(EquipType.Head)]
    public class TrenagonMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Trenagon Mask");
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
            //player.maxMinions += 1;
            //player.AddBuff(BuffID.Shine, 2);
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("TrenagonChestplate") && legs.type == mod.ItemType("TrenagonGreaves");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "10% Increased Damage";
            player.meleeDamage += 0.1f;
            player.magicDamage += 0.1f;
            player.minionDamage += 0.1f;
            player.rangedDamage += 0.1f;
            player.thrownDamage += 0.1f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "TrenagonBar", 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}