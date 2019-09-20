using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Consumables
{
    public class GoldenEyeball : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Summons Eye of Cthulhu Infinitely");
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
            recipe.AddIngredient(ItemID.SuspiciousLookingEye, 10);
            recipe.AddTile(26);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.EyeofCthulhu);
            return true;
        }
    }
}