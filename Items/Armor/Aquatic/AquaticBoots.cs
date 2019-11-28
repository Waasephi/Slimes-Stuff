using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Aquatic
{
    [AutoloadEquip(EquipType.Legs)]
    public class AquaticBoots : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Aquatic Boots");
            Tooltip.SetDefault("+12% Movement Speed" +
                "\n[c/00f2ff:-Spirit Class-]");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 10;
            item.value = 100;
            item.rare = 9;
            item.defense = 14;
        }



        public override void UpdateEquip(Player player)
        {
            player.moveSpeed *= 1.12f;
            //player.maxMinions+=2;
            //player.AddBuff(BuffID.Shine, 2);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Coral, 25);
            recipe.AddIngredient(ItemID.HallowedBar, 15);
            recipe.AddTile(134);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}