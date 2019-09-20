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

    public class BottledDune : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bottled Dune");
        }
        public override void SetDefaults()
        {
            item.maxStack = 999;                 //this is where you set the max stack of item
            item.consumable = false;           //this make that the item is consumable when used
            item.width = 40;
            item.height = 52;
            item.value = 100;                
            item.rare = 4;
			item.expert = true;
			item.autoReuse = true;
        }
    }
}