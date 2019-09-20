using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Consumables
{
    public class GoldenHeart : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Summons The Keeper Of Life Infinitely, Must Be Used Underground");
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
            recipe.AddIngredient(mod,"CrystalHeart", 10);
            recipe.AddTile(26);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool CanUseItem(Player player)
        {
            return player.ZoneRockLayerHeight;
        }

        public override bool UseItem(Player player)
        {
            Main.NewText("You are hurting this world! Please stop.", 250, 200, 200);
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("LifeEnforcer"));
            return true;
        }
    }
}