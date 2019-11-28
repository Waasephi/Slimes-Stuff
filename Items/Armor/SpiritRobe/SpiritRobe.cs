using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using OurStuffAddon.Items.SpiritDamageClass;

namespace OurStuffAddon.Items.Armor.SpiritRobe
{
    [AutoloadEquip(EquipType.Body)]
    public class SpiritRobe : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Spirit Robe");
            Tooltip.SetDefault("+20% [c/00f2ff:Spirit Crit], +15% Endurance" +
                "\n[c/00f2ff:-Spirit Class-]");
        }

        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 24;
            item.value = 100;
            item.rare = 2;
            item.defense = 20;
        }

        public override void UpdateEquip(Player player)
        {
            SpiritDamagePlayer modPlayer = SpiritDamagePlayer.ModPlayer(player);
            modPlayer.spiritCrit += 20; // add 5% crit
            player.endurance *= 1.15f;
            //player.statManaMax2 += 20;
            //player.maxMinions++;
            //player.AddBuff(BuffID.Shine, 2);
        }



        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "SpiritInfusedBar", 20);
            recipe.AddIngredient(mod, "Ectoheart");
            recipe.AddTile(mod, "SpiritInfuser");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}