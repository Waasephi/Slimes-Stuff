using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Spiricite
{
    [AutoloadEquip(EquipType.Legs)]
    public class SpiriciteShoes : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Spiricite Shoes");
            Tooltip.SetDefault("+7% Movement Speed" +
                "\n[c/00f2ff:-Spirit Class-]");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 10;
            item.value = 100;
            item.rare = 2;
            item.defense = 4;
        }



        public override void UpdateEquip(Player player)
        {
            player.moveSpeed *= 1.07f;
            //player.maxMinions+=2;
            //player.AddBuff(BuffID.Shine, 2);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "SpiriciteCrystal", 15);
            recipe.AddTile(mod, "SpiritInfuser");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}