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
		}
        public override void SetDefaults()
        {
            item.maxStack = 999;                 //this is where you set the max stack of item
            item.consumable = false;           //this make that the item is consumable when used
            item.width = 28;
            item.height = 28;
            item.value = Item.sellPrice(0, 0, 2, 0);
            item.value = Item.buyPrice(0, 1, 0, 0);
            item.rare = 0;
			item.expert = false;
			item.autoReuse = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
            ItemID.Sets.ItemIconPulse[item.type] = true;
        }
    }
}