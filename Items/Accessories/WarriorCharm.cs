using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Accessories
{
    public class WarriorCharm : ModItem //replace ItemName with the name of your accessory
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Warrior Charm");
            Tooltip.SetDefault("Harness the power of the Body and push your Strength beyond (Raises Melee Damage By 1/3 But Lowers Melee Speed).");
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.meleeDamage += .3f;
            player.meleeSpeed -= .1f;
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
            recipe.AddIngredient(178, 50);
            recipe.AddIngredient(231, 1);
            recipe.AddIngredient(232, 1);
            recipe.AddIngredient(233, 1);
            recipe.AddTile(114);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
