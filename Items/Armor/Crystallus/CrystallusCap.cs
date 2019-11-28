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

namespace OurStuffAddon.Items.Armor.Crystallus
{
    [AutoloadEquip(EquipType.Head)]
    public class CrystallusCap : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Crystallus Cap");
            Tooltip.SetDefault("+15% [c/00f2ff:Spirit Damage]" +
                "\n[c/00f2ff:-Spirit Class-]");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 10;
            item.value = 100;
            item.rare = 5;
            item.defense = 9;
        }

        public override void UpdateEquip(Player player)
        {
            SpiritDamagePlayer modPlayer = SpiritDamagePlayer.ModPlayer(player);
            //player.endurance *= 1.05f;
            //player.statManaMax2 += 20;
            modPlayer.spiritDamageMult *= 1.15f; // add 20% to the multiplicative bonus
            //player.AddBuff(BuffID.Shine, 2);
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("CrystallusChestplate") && legs.type == mod.ItemType("CrystallusLeggings");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Spelunker effect, Shine effect, +3 Defence, +16% [c/00f2ff:Spirit Damage].";
            player.findTreasure = true;
            Lighting.AddLight((int)(player.position.X + (float)(player.width / 2)) / 16, (int)(player.position.Y + (float)(player.height / 2)) / 16, 0.8f, 0.95f, 1f);
            player.statDefense += 3;
            SpiritDamagePlayer modPlayer = SpiritDamagePlayer.ModPlayer(player);
            modPlayer.spiritDamageMult *= 1.16f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrystalShard, 10);
            recipe.AddIngredient(mod, "AncientCore");
            recipe.AddIngredient(520, 5);
            recipe.AddTile(134);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}