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

namespace OurStuffAddon.Items.Armor.HMThrown
{
    [AutoloadEquip(EquipType.Head)]
    public class OrichalcumHeadpiece : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Orichalcum Headpiece");
            Tooltip.SetDefault(" 13% Thrown Damage");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 10;
            item.value = 100;
            item.rare = 10;
            item.defense = 12;
        }

        public override void UpdateEquip(Player player)
        {
            //player.endurance *= 1.05f;
            player.thrownDamage *= 1.13f;
            //player.AddBuff(BuffID.Shine, 2);
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == (ItemID.OrichalcumBreastplate) && legs.type == (ItemID.OrichalcumLeggings);
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+17% thrown velocity and +5% endurance.";
            player.thrownVelocity *= 1.17f;
            player.endurance *= 1.05f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.OrichalcumBar, 12);
            recipe.AddTile(134);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}