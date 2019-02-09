using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.SandScale
{
    [AutoloadEquip(EquipType.Body)]
    public class SandScalePlate : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Sand Scale Plate");
            Tooltip.SetDefault("1/5 increase in damage");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.value = 100;
            item.rare = 2;
            item.defense = 7;
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeDamage += 0.2f;
            player.magicDamage += 0.2f;
            player.minionDamage += 0.2f;
            player.rangedDamage += 0.2f;
            player.thrownDamage += 0.2f;
            //player.statManaMax2 += 20;
            //player.maxMinions++;
            //player.AddBuff(BuffID.Shine, 2);
        }



        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "SandSifterMandible", 10);
            recipe.AddIngredient(mod, "SandSifterScale", 20);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}