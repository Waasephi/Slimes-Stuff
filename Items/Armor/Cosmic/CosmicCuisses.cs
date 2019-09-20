using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Armor.Cosmic
{
    [AutoloadEquip(EquipType.Legs)]
    public class CosmicCuisses : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Cosmic Cuisses");
            Tooltip.SetDefault("\n+20 %Movement Speed, +20 Max Life, +33% Thrown Velocity");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 10;
            item.value = 100;
            item.rare = 11;
            item.defense = 16;
        }



        public override void UpdateEquip(Player player)
        {
            player.moveSpeed *= 1.20f;
            player.statLifeMax2 += 20;
            player.thrownVelocity += .33f;
            //player.maxMinions+=2;
            //player.AddBuff(BuffID.Shine, 2);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 12);
            recipe.AddIngredient(mod, "CosmicFragment", 15);
            recipe.AddTile(412);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}