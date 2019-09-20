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
    public class RuinedRelic : ModItem //replace ItemName with the name of your accessory
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ruined Relic");
            Tooltip.SetDefault("Increased Thrown Attack Speed And Damage.");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(6, 2));
        }
        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.thrownDamage += .03f;
            player.meleeSpeed += .2f;
        }
        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 20;
            item.value = 10000;
            item.rare = 2;
            item.accessory = true;
        }
    }
}
