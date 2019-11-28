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

    public class PsychicSand : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Psychic Sand");
            Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(8, 5));
        }
        public override void SetDefaults()
        {
            item.maxStack = 999;                 //this is where you set the max stack of item
            item.consumable = false;           //this make that the item is consumable when used
            item.width = 28;
            item.height = 18;
            item.value = 100;                
            item.rare = 1;
			item.expert = false;
			item.autoReuse = true;
        }
    }
}