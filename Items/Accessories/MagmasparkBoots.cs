using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Accessories
{
    public class MagmasparkBoots : ModItem //replace ItemName with the name of your accessory
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magmaspark Boots");
            Tooltip.SetDefault("Run like the wind! (Frostspark Boots, and Lava Wader Buffs)");
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.ignoreWater = true;
            player.waterWalk = true;
            player.moveSpeed += 2.5f;
            player.maxRunSpeed += 2.5f;
            player.iceSkate = true;
            player.rocketBoots = 2;
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
            recipe.AddIngredient(ItemID.FrostsparkBoots);
            recipe.AddIngredient(ItemID.LavaWaders);
            recipe.AddIngredient(547);
            recipe.AddIngredient(548);
            recipe.AddIngredient(549);
            recipe.AddTile(114);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
