using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Phasite
{
    [AutoloadEquip(EquipType.Body)]
    public class PhasiteChestplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Phasite Chestplate");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.value = 100;
            item.rare = 2;
            item.defense = 6;
        }

        public override void UpdateEquip(Player player)
        {
            //player.statManaMax2 += 20;
            //player.maxMinions++;
            //player.AddBuff(BuffID.Shine, 2);
        }



        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "PhasiteBar", 20);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}