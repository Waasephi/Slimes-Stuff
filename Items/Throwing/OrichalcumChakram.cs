using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Throwing
{
    public class OrichalcumChakram : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Orichalcum Chakram");
        }
        public override void SetDefaults()
        {
                item.damage = 40;
                item.thrown = true;
                item.width = 30;
                item.height = 30;
                item.useTime = 23;
                item.useAnimation = 23;
                item.noUseGraphic = true;
                item.useStyle = 1;
                item.knockBack = 3;
                item.value = 8;
                item.rare = 6;
                item.shootSpeed = 12f;
                item.shoot = mod.ProjectileType("OrichalcumChakramProjectile");
                item.UseSound = SoundID.Item1;
                item.autoReuse = true;
        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.OrichalcumBar, 15);
            recipe.AddTile(134);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}