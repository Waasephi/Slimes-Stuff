using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Accessories
{
    public class MoltenShield : ModItem //replace ItemName with the name of your accessory
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("For the true Warrior. (+3 Defence, Obsidian Shield and Magma Stone Buffs)");
        }
        public override void UpdateAccessory(Player player, bool hideVisual) //Where it says "p" is the variable used to represent "player". In this case, every p stands for player. This is called when the accessory is on.
        {
            player.statLife += 20;//This is where an effect from the list goes.
            player.fireWalk = true;
            player.noKnockback = true;
            player.magmaStone = true;
            player.statDefense += 3;
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
            recipe.AddIngredient(397, 1);
            recipe.AddIngredient(175, 50);
            recipe.AddIngredient(1322, 1);
            recipe.AddTile(114);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
