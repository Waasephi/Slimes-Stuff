using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.SandScale
{
    [AutoloadEquip(EquipType.Legs)]
    public class SandScaleBoots : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Sand Scale Boots");
            Tooltip.SetDefault("\n+10 %Movement Speed"
            + "\n+20 Mana");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 10;
            item.value = 100;
            item.rare = 2;
            item.defense = 6;
        }



        public override void UpdateEquip(Player player)
        {
            player.moveSpeed *= 1.10f;
            player.statManaMax2 += 20;
            //player.maxMinions+=2;
            //player.AddBuff(BuffID.Shine, 2);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "SandSifterMandible", 7);
            recipe.AddIngredient(mod, "SandSifterScale", 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}