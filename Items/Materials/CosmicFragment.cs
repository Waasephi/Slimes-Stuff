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

namespace OurStuffAddon.Items.Materials{

    public class CosmicFragment : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cosmic Fragment");
			Tooltip.SetDefault("You can feel the cosmic power radiating from it.");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(3, 8));
        }
        public override void SetDefaults()
        {
            item.maxStack = 999;                 //this is where you set the max stack of item
            item.consumable = false;           //this make that the item is consumable when used
            item.width = 80;
            item.height = 112;
            item.value = 100;                
            item.rare = 4;
			item.expert = true;
			item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(3458, 5);
			recipe.AddIngredient(3456, 5);
			recipe.AddIngredient(3457, 5);
			recipe.AddIngredient(3459, 5);
            recipe.AddTile(412);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
		
    }
}