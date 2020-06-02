using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Ranged
{
    public class Noctem : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Noctem");
        }
        public override void SetDefaults()
        {
            item.damage = 40;
            item.ranged = true;
            item.width = 36;
            item.height = 28;
            item.useTime = 5;
            item.useAnimation = 16;
            item.useStyle = 5;
            item.reuseDelay = 18;
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 4;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.shoot = 10;    //idk why but all the guns in the vanilla source have this
            item.shootSpeed = 12f;
            item.useAmmo = AmmoID.Bullet;
        }

        public override bool ConsumeAmmo(Player player)
        {
            // Because of how the game works, player.itemAnimation will be 11, 7, and finally 3. (UseAmination - 1, then - useTime until less than 0.) 
            // We can get the Clockwork Assault Riffle Effect by not consuming ammo when itemAnimation is lower than the first shot.
            return !(player.itemAnimation < item.useAnimation - 3);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "BugBite", 1);
            recipe.AddIngredient(mod, "AncientBlaster", 1);
            recipe.AddIngredient(mod, "InfernalSniper", 1);
            recipe.AddRecipeGroup("OurStuffAddon:EvilGun");
            recipe.AddTile(26);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }





    }



}