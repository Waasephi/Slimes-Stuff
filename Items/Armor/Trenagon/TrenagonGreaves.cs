using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Trenagon
{
    [AutoloadEquip(EquipType.Legs)]
    public class TrenagonGreaves : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Trenagon Greaves");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 10;
            item.value = 100;
            item.rare = 2;
            item.defense = 3;
        }



        public override void UpdateEquip(Player player)
        {
            //player.moveSpeed *= 1.10f;
            //player.statManaMax2 += 20;
            //player.maxMinions+=2;
            //player.AddBuff(BuffID.Shine, 2);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "TrenagonBar", 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}