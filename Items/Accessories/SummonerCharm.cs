using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Accessories
{
    public class SummonerCharm : ModItem //replace ItemName with the name of your accessory
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Summoner Charm");
            Tooltip.SetDefault("Harness the power of the Mind and push your Leadership beyond (Lowers Minion Damage By 1/5 But Gives 3 Minion Slots).");
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.minionDamage -= .2f;
            player.maxMinions += 3;
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
            recipe.AddIngredient(999, 50);
            recipe.AddIngredient(2361, 1);
            recipe.AddIngredient(2362, 1);
            recipe.AddIngredient(2363, 1);
            recipe.AddTile(114);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
