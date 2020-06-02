using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using OurStuffAddon.Items.SpiritDamageClass;

namespace OurStuffAddon.Items.Accessories
{
    public class CrystalizedParasite : ModItem //replace ItemName with the name of your accessory
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crystalized Parasite");
            Tooltip.SetDefault("+7% [c/00f2ff:Spirit Damage]." +
                "\n[c/00f2ff:-Spirit Class-]");
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            SpiritDamagePlayer modPlayer = SpiritDamagePlayer.ModPlayer(player);
            modPlayer.spiritDamageMult *= 1.07f;
        }
        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 20;
            item.value = Item.sellPrice(gold: 1);
            item.rare = 2;
            item.accessory = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "SeafoamCrystal", 50);
            recipe.AddIngredient(mod, "SeafoamScale", 20);
            recipe.AddTile(114);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
