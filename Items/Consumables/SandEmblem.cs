using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Consumables
{
    public class SandEmblem : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Summons The Sand Sifter Leader");
        }
        public override void SetDefaults()
        {
            item.width = 16;
            item.height = 20;
            item.maxStack = 999;
            item.rare = 1;
            item.useAnimation = 45;
            item.useTime = 45;
            item.useStyle = 4;
            item.UseSound = SoundID.Item15;
            item.consumable = true;
        }

        public override bool CanUseItem(Player player)
        {
            return player.ZoneUndergroundDesert;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.AntlionMandible, 5);
            recipe.AddIngredient(mod, "SandSifterScale", 5);
            recipe.AddTile(26);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }



        public override bool UseItem(Player player)
        {
             NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("GiantSandSifterHead"));
            return true;
        }
    }
}