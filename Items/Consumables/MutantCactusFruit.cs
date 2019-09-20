using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.DataStructures;

namespace OurStuffAddon.Items.Consumables
{
    public class MutantCactusFruit : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName and Tooltip are automatically set from the .lang files, but below is how it is done normally.
            // DisplayName.SetDefault("Paper Airplane");
            // Tooltip.SetDefault("Summons a Paper Airplane to follow aimlessly behind you");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Carrot);
            item.shoot = mod.ProjectileType("BabyCactus");
            item.buffType = mod.BuffType("BabyCactus");
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Cactus, 100);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}