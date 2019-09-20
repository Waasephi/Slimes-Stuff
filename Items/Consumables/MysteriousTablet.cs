using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.DataStructures;

namespace OurStuffAddon.Items.Consumables
{
    public class MysteriousTablet : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Summons Lunatic Cultist");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(8, 4));
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

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(3459, 5);
            recipe.AddIngredient(3458, 5);
            recipe.AddIngredient(3457, 5);
            recipe.AddIngredient(3456, 5);
            recipe.AddTile(26);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, NPCID.CultistBoss);
            return true;
        }
    }
}