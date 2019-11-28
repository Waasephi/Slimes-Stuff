using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Ranged.Ammo
{
    public class EndlessSoulQuiver : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Endless Spirit Quiver");
            Tooltip.SetDefault("Pierces the soul, never runs out.");
        }
        public override void SetDefaults()
        {
            item.damage = 5;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.maxStack = 1;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 1.5f;
            item.value = 1;
            item.rare = 1;
            item.shoot = mod.ProjectileType("SpiritArrowProjectile");   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 5f;                  //The speed of the projectile
            item.ammo = AmmoID.Arrow;              //The ammo class this ammo belongs to.
        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "SpiritArrow", 3996);
            recipe.AddTile(mod, "SpiritInfuser");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }



    }



}