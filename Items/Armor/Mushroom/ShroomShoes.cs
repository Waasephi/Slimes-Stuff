using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Mushroom
{
    [AutoloadEquip(EquipType.Legs)]
    public class ShroomShoes : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Shroom Shoes");
            Tooltip.SetDefault("\n+15 %Movement Speed"
            + "\n+20 Mana");
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
            player.moveSpeed *= 1.15f;
            player.statManaMax2 += 20;
            //player.maxMinions+=2;
            //player.AddBuff(BuffID.Shine, 2);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GlowingMushroom, 25);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}