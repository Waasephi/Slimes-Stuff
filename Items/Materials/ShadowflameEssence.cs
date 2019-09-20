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

namespace OurStuffAddon.Items.Materials{

    public class ShadowflameEssence : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shadowflame Essence");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(3, 4));
        }
        public override void SetDefaults()
        {
            item.maxStack = 999;                 //this is where you set the max stack of item
            item.consumable = false;           //this make that the item is consumable when used
            item.width = 14;
            item.height = 22;
            item.value = 100;                
            item.rare = 4;
			item.expert = false;
			item.autoReuse = true;
        }
        // The following 2 methods are purely to show off these 2 hooks. Don't use them in your own code.
        public override void GrabRange(Player player, ref int grabRange)
        {
            grabRange *= 3;
        }

        public override bool GrabStyle(Player player)
        {
            Vector2 vectorItemToPlayer = player.Center - item.Center;
            Vector2 movement = -vectorItemToPlayer.SafeNormalize(default(Vector2)) * 0.1f;
            item.velocity = item.velocity + movement;
            item.velocity = Collision.TileCollision(item.position, item.velocity, item.width, item.height);
            return true;
        }

        public override void PostUpdate()
        {
            Lighting.AddLight(item.Center, Color.WhiteSmoke.ToVector3() * 0.55f * Main.essScale);
        }
    }
}