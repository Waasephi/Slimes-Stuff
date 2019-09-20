using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Accessories
{
    public class ThrowerEmblem : ModItem //replace ItemName with the name of your accessory
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ninja Emblem");
            Tooltip.SetDefault("+15% Thrown Damage.");
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.thrownDamage += .15f;
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
            recipe.AddIngredient(mod,"ThrowerEmblem");
            recipe.AddIngredient(548, 5);
            recipe.AddIngredient(547, 5);
            recipe.AddIngredient(549, 5);
            recipe.AddTile(114);
            recipe.SetResult(ItemID.AvengerEmblem);
            recipe.AddRecipe();
        }
    }
}
