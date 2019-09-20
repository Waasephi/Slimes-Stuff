using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Accessories
{
    public class ObsidianGauntlet : ModItem //replace ItemName with the name of your accessory
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Obsidian Gauntlet");
            Tooltip.SetDefault("Harness the power of the fire and ice in your hands. (+4 Defence, Buffed Fire Gauntlet and Frost Stone Buffs)");
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.magmaStone = true;
            player.frostBurn = true;
            player.meleeSpeed += 0.3f;
            player.kbGlove = true;
            player.meleeDamage += 0.3f;
            player.statDefense += 4;
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
            recipe.AddIngredient(1343, 1);
            recipe.AddIngredient(mod, "FrostGauntlet");
            recipe.AddTile(114);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
