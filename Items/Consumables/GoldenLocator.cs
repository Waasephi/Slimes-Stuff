using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Consumables
{
    public class GoldenLocator : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Summons A Interstellar Enemy Infinitely");
        }
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 20;
            item.maxStack = 999;
            item.rare = 1;
            item.useAnimation = 45;
            item.useTime = 45;
            item.useStyle = 4;
            item.UseSound = SoundID.Item15;
            item.consumable = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod,"NeoLocator", 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }



        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("NeoMothership"));
            return true;
        }
    }
}