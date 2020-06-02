using Terraria.ID;
using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace OurStuffAddon.Items.Melee
{
    public class SkyEruption : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sky Eruption");
        }
        public override void SetDefaults()
        {
            item.damage = 25;
            item.melee = true;
            item.width = 34;
            item.height = 40;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 1;
            item.knockBack = 4;
            item.value = 10000;
            item.rare = 2;
            item.shoot = mod.ProjectileType("EruptionProjectile");
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shootSpeed = 10f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BoneSword);
            recipe.AddIngredient(ItemID.IceBlade);
            recipe.AddIngredient(ItemID.Starfury);
            recipe.AddIngredient(ItemID.EnchantedSword);
            recipe.AddTile(26);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
