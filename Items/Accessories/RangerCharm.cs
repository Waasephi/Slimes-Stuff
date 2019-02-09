using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Accessories
{
    public class RangerCharm : ModItem //replace ItemName with the name of your accessory
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ranger Charm");
            Tooltip.SetDefault("Harness the power of the Sight and push your Ranged Abilities beyond (Increases Ranged Damage By 1/3 But Lowers Crit Chance).");
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.rangedDamage += .3f;
            player.rangedCrit -= 10;
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
            recipe.AddIngredient(179, 50);
            recipe.AddIngredient(151, 1);
            recipe.AddIngredient(152, 1);
            recipe.AddIngredient(153, 1);
            recipe.AddTile(114);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
