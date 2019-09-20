using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Magic
{
    public class MythrilStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mythril Staff");
            Item.staff[item.type] = true;
        }
        public override void SetDefaults()
        {
            item.damage = 34;
            item.magic = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 26;
            item.useAnimation = 26;
            item.useStyle = 5;
            item.knockBack = 2;
            item.value = 100;
            item.rare = 6;
            item.UseSound = SoundID.Item43;
            item.autoReuse = true;
            item.shoot = 124;
            item.shootSpeed = 8f;
            item.mana = 17;
            item.noMelee = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MythrilBar, 10);
            recipe.AddTile(134);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}