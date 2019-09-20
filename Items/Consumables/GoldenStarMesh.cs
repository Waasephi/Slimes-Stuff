using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Consumables
{
    public class GoldenStarMesh : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Summons A Cosmic Amalgamation Infinitely");
        }
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 20;
            item.maxStack = 1;
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
            recipe.AddIngredient(mod, "CosmicStarMesh", 10);
            recipe.AddTile(412);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }



        public override bool UseItem(Player player)
        {
            Main.NewText("You think all slimes are pushovers? Please... you havent seen our best.", 200, 0, 250);
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("CosmicSlime"));
            return true;
        }
    }
}