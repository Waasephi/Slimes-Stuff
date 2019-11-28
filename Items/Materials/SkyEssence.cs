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

namespace OurStuffAddon.Items.Materials
{

    public class SkyEssence : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sky Essence");
			Tooltip.SetDefault("It is so soft.");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 16));
		}
        public override void SetDefaults()
        {
            item.maxStack = 999;                 //this is where you set the max stack of item
            item.consumable = false;           //this make that the item is consumable when used
            item.width = 80;
            item.height = 112;
            item.value = 10000;                
            item.rare = 0;
			item.expert = false;
			item.autoReuse = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
        }
    }
}