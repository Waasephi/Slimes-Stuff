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

namespace OurStuffAddon.Items.Accessories
{
    public class CosmicCore : ModItem //replace ItemName with the name of your accessory
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cosmic Core");
            Tooltip.SetDefault("Greatly Increased Thrown Speed");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(6, 4));
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.meleeSpeed += 3f;
        }
        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 20;
            item.value = 10000;
            item.rare = 2;
            item.accessory = true;
            item.expert = true;
        }
    }
}
