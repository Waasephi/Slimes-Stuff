using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Throwing
{
    public class TerraJavelin : ModItem

    {

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Terra Javelin");
        }
        public override void SetDefaults()
        {
            item.damage = 100;           //this is the item damage
            item.thrown = true;             //this make the item do throwing damage
            item.noMelee = true;
            item.width = 22;
            item.height = 22;
            item.useTime = 10;       //this is how fast you use the item
            item.useAnimation = 10;   //this is how fast the animation when the item is used
            item.useStyle = 1;
            item.knockBack = 4;
            item.value = 10;
            item.rare = 2;
            item.reuseDelay = 6;    //this is the item delay
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;       //this make the item auto reuse
            item.shoot = mod.ProjectileType("TerraJavelinProjectile");
            item.shootSpeed = 15f;     //projectile speed
            item.useTurn = true;
            item.maxStack = 1;       //this is the max stack of this item
            item.consumable = false;  //this make the item consumable when used
            item.noUseGraphic = true;
 

        }
        public override void AddRecipes()  //How to craft this item
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddRecipeGroup("OurStuffAddon:TrueEvilJavelin");
            recipe.AddIngredient(mod, "TrueHolyJavelin");
            recipe.AddTile(134);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            // Here we manually spawn the 2nd projectile, manually specifying the projectile type that we wish to shoot.
            Projectile.NewProjectile(position.X - 20, position.Y, speedX *= 2, speedY *= 2, mod.ProjectileType("TrueNightJavelinProjectile"), damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X + 20, position.Y, speedX *= 2, speedY *= 2, mod.ProjectileType("TrueHolyJavelinProjectile"), damage, knockBack, player.whoAmI);
            return true;
        }
    }
}