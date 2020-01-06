using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Relic
{
    [AutoloadEquip(EquipType.Legs)]
    public class RelicGreaves : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Relic Greaves");
            Tooltip.SetDefault("+7% Movement Speed");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 10;
            item.value = 100;
            item.rare = -1;
            item.defense = 5;
        }



        public override void UpdateEquip(Player player)
        {
            player.moveSpeed *= 1.07f;
            //player.statManaMax2 += 20;
            //player.maxMinions+=2;
            //player.AddBuff(BuffID.Shine, 2);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldGreaves);
            recipe.AddIngredient(mod, "RelicShard", 15);
            recipe.AddIngredient(mod, "ChippedStone", 7);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}