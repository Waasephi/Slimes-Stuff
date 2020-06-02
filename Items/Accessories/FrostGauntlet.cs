using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Accessories
{
    public class FrostGauntlet : ModItem //replace ItemName with the name of your accessory
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Frost Gauntlet");
            Tooltip.SetDefault("Harness the power of the ice in your hands. (Mechanical Glove and Frost Stone Buffs)");
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.frostBurn = true;
            player.meleeSpeed += 0.1f;
            player.kbGlove = true;
            player.meleeDamage += 0.1f;
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
            recipe.AddIngredient(ItemID.MechanicalGlove, 1);
            recipe.AddIngredient(mod, "FrostStone");
            recipe.AddTile(114);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
