using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Accessories
{
    public class NinjaCharm : ModItem //replace ItemName with the name of your accessory
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ninja Charm");
            Tooltip.SetDefault("Harness the power of the spirit and push your Throwing beyond (Increases Throwing Damage By 1/3 But Lowers Attack Speed).");
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.thrownDamage += .3f;
            player.meleeSpeed -= .2f;
        }
        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 20;
            item.value = 10000;
            item.rare = 2;
            item.accessory = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(182, 50);
            recipe.AddIngredient(3374, 1);
            recipe.AddIngredient(3375, 1);
            recipe.AddIngredient(3376, 1);
            recipe.AddTile(114);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
