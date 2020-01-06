using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Relic
{
    [AutoloadEquip(EquipType.Body)]
    public class RelicChestplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Relic Chestplate");
            Tooltip.SetDefault("+5% Thrown Damage");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.value = 100;
            item.rare = -1;
            item.defense = 5;
        }

        public override void UpdateEquip(Player player)
        {
            player.thrownDamage *= 1.05f;
            //player.statManaMax2 += 20;
            //player.maxMinions++;
            //player.AddBuff(BuffID.Shine, 2);
        }



        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldChainmail);
            recipe.AddIngredient(mod, "RelicShard", 20);
            recipe.AddIngredient(mod, "ChippedStone", 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}