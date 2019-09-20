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

    public class SeafoamScale : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Seafoam Scale");
		}
        public override void SetDefaults()
        {
            item.maxStack = 999;                 //this is where you set the max stack of item
            item.consumable = false;           //this make that the item is consumable when used
            item.width = 24;
            item.height = 30;
            item.value = 7500;                
            item.rare = 4;
			item.expert = false;
			item.autoReuse = true;
        }
    }
}