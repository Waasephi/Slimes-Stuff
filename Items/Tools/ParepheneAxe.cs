using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Tools
{
    public class ParepheneAxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Parephene Axe");
        }

        public override void SetDefaults()
        {
            item.damage = 42;
            item.melee = true;
            item.width = 32;
            item.height = 28;
            item.useTime = 25;
            item.useAnimation = 25;
            item.axe = 20;
            item.useStyle = 1;
            item.knockBack = 7;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "ParepheneBar", 14);
            recipe.AddIngredient(ItemID. Wood, 12);
            recipe.AddTile(134);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}