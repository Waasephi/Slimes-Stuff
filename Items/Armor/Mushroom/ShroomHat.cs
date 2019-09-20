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

namespace OurStuffAddon.Items.Armor.Mushroom
{
    [AutoloadEquip(EquipType.Head)]
    public class ShroomHat : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Shroom Hat");
            Tooltip.SetDefault("\n+1 Minions");
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
            player.maxMinions += 1;
            //player.AddBuff(BuffID.Shine, 2);
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == mod.ItemType("ShroomShirt") && legs.type == mod.ItemType("ShroomShoes");
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "Increased Life Regen, +1 Minion, Gives a dim blue glow.";
            player.lifeRegen += 1;
            player.maxMinions += 1;
            Lighting.AddLight((int)(player.position.X + (float)(player.width / 2)) / 16, (int)(player.position.Y + (float)(player.height / 2)) / 16, 0f, 0f, 1f);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GlowingMushroom, 20);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}