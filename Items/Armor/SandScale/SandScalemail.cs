using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.SandScale
{
    [AutoloadEquip(EquipType.Body)]
    public class SandScalemail : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Sand Scalemail");
            Tooltip.SetDefault("5% increase in minion damage");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.value = 100;
            item.rare = 2;
            item.defense = 4;
        }

        public override void UpdateEquip(Player player)
        {
            player.minionDamage += 0.05f;
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