using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using OurStuffAddon.Items.SpiritDamageClass;

namespace OurStuffAddon.Items.Armor.Magmatic
{
    [AutoloadEquip(EquipType.Body)]
    public class MagmaticArmor : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Magmatic Armor");
            Tooltip.SetDefault("+20% [c/00f2ff:Spirit Crit]" +
                "\n[c/00f2ff:-Spirit Class-]");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.value = 100;
            item.rare = 5;
            item.defense = 10;
        }

        public override void UpdateEquip(Player player)
        {
            SpiritDamagePlayer modPlayer = SpiritDamagePlayer.ModPlayer(player);
            modPlayer.spiritCrit += 17; // add 5% crit
            player.endurance *= 1.2f;
            //player.statManaMax2 += 20;
            //player.maxMinions++;
            //player.AddBuff(BuffID.Shine, 2);
        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "LavaShard");
            recipe.AddIngredient(ItemID.AshBlock, 150);
            recipe.AddIngredient(ItemID.HellstoneBar, 20);
            recipe.AddIngredient(ItemID.HallowedBar, 20);
            recipe.AddTile(134);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}