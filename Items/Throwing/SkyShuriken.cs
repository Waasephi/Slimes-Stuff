using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Throwing
{
    public class SkyShuriken : ModItem

    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sky Shuriken");
        }
        public override void SetDefaults()
        {
            item.damage = 25;           //this is the item damage
            item.thrown = true;             //this make the item do throwing damage
            item.noMelee = true;
            item.width = 21;
            item.height = 30;
            item.useTime = 15;       //this is how fast you use the item
            item.useAnimation = 15;   //this is how fast the animation when the item is used
            item.useStyle = 1;
            item.knockBack = 4;
            item.value = 10;
            item.rare = 2;
            item.reuseDelay = 3;    //this is the item delay
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;       //this make the item auto reuse
            item.shoot = mod.ProjectileType("SkyShurikenProjectile");
            item.shootSpeed = 10f;     //projectile speed
            item.useTurn = true;
            item.maxStack = 1;       //this is the max stack of this item
            item.consumable = false;  //this make the item consumable when used
            item.noUseGraphic = true;
 

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("SkyEssence"), 20);
            recipe.AddTile(TileID.SkyMill);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}