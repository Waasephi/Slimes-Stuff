using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Consumables
{
    public class RelicPebble : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Summons An Ancient Beast, Must Be Used In The Ruin");
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
            item.consumable = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod,"RelicShard", 5);
            recipe.AddIngredient(mod,"AncientStone", 100);
            recipe.AddTile(26);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool CanUseItem(Player player)
        {
            return player.GetModPlayer<OurStuffAddonPlayer>().ZoneRuin;
        }

        public override bool UseItem(Player player)
        {
            if (OurStuffAddonWorld.downedAncientObserver == true)
            {
                Main.NewText("Why do you do this to the creatures of this world?", 70, 70, 0);
            }
            else
                Main.NewText("*Unintelligible Screeching*", 70, 70, 0);
            NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("AncientObserver"));
            return true;
        }
    }
}