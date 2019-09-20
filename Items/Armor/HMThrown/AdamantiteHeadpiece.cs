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
    public class AdamantiteHeadpiece : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Adamantite Headpiece");
            Tooltip.SetDefault(" 15% Thrown Damage");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 10;
            item.value = 100;
            item.rare = 10;
            item.defense = 15;
        }

        public override void UpdateEquip(Player player)
        {
            //player.endurance *= 1.05f;
            player.thrownDamage *= 1.15f;
            //player.AddBuff(BuffID.Shine, 2);
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == (ItemID.AdamantiteBreastplate) && legs.type == (ItemID.AdamantiteLeggings);
        }

        public override void UpdateArmorSet(Player player)
        {
            player.setBonus = "+20% thrown velocity and movement speed.";
            player.moveSpeed *= 1.20f;
            player.thrownVelocity *= 1.20f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AdamantiteBar, 12);
            recipe.AddTile(134);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}