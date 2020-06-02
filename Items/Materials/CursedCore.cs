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

    public class CursedCore : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cursed Core");
            Tooltip.SetDefault("It burns to hold.");
        }
        public override void SetDefaults()
        {
            item.maxStack = 999;                 //this is where you set the max stack of item
            item.consumable = false;           //this make that the item is consumable when used
            item.width = 42;
            item.height = 42;
            item.value = Item.sellPrice(0, 1, 25, 0);
            item.rare = 7;
			item.expert = false;
			item.autoReuse = true;
        }
    }
}