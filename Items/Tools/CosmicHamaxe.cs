using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Tools
{
    public class CosmicHamaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
        }

        public override void SetDefaults()
        {
            item.damage = 60;
            item.melee = true;
            item.width = 38;
            item.height = 38;
            item.useTime = 8;
            item.useAnimation = 8;
            item.axe = 30;
            item.hammer = 100;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.tileBoost += 4;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "CosmicFragment", 14);
            recipe.AddIngredient(ItemID. LunarBar, 12);
            recipe.AddTile(412);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}