using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Throwing
{
    public class MythrilChakram : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mythril Chakram");
        }
        public override void SetDefaults()
        {
                item.damage = 35;
                item.thrown = true;
                item.width = 30;
                item.height = 30;
                item.useTime = 25;
                item.useAnimation = 25;
                item.noUseGraphic = true;
                item.useStyle = 1;
                item.knockBack = 3;
                item.value = 8;
                item.rare = 6;
                item.shootSpeed = 12f;
                item.shoot = mod.ProjectileType("MythrilChakramProjectile");
                item.UseSound = SoundID.Item1;
                item.autoReuse = true;
        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MythrilBar, 15);
            recipe.AddTile(134);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}