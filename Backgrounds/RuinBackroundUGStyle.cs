using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Backgrounds
{
    public class RuinBackgroundUG : ModUgBgStyle
    {
        public override bool ChooseBgStyle()
        {
            return Main.LocalPlayer.GetModPlayer<OurStuffAddonPlayer>().ZoneRuin;
        }

        public override void FillTextureArray(int[] textureSlots)
        {
            textureSlots[0] = mod.GetBackgroundSlot("Backgrounds/RuinUG0");
            textureSlots[1] = mod.GetBackgroundSlot("Backgrounds/RuinUG1");
            textureSlots[2] = mod.GetBackgroundSlot("Backgrounds/RuinUG2");
            textureSlots[3] = mod.GetBackgroundSlot("Backgrounds/RuinUG3");
        }
    }
}