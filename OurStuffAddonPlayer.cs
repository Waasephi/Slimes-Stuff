using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon
{
    public partial class OurStuffAddonPlayer : ModPlayer
    {
        public bool Tippi;
        public bool ShroomBuff;
        public bool SpiritPet;
        public bool BabyCactus;
        public bool blueSlime;

        public override void ResetEffects()
        {
            SpiritPet = false;
            Tippi = false;
            ShroomBuff = false;
            blueSlime = false;
            BabyCactus = false;
        }
        public bool ZoneLuminescentLagoon;
        public bool ZoneRuin;
        public bool ZonePlague;
        public override void UpdateBiomes()
        {
            ZoneLuminescentLagoon = OurStuffAddonWorld.LuminescentLagoon > 100;
            ZoneRuin = OurStuffAddonWorld.Ruin > 100;
            ZonePlague = OurStuffAddonWorld.Plague > 100;
        }
        public override void SendCustomBiomes(BinaryWriter writer)
        {
            BitsByte flags = new BitsByte();
            flags[0] = ZoneLuminescentLagoon;
            flags[1] = ZoneRuin;
            flags[2] = ZonePlague;
            writer.Write(flags);
        }
        public override void ReceiveCustomBiomes(BinaryReader reader)
        {
            BitsByte flags = reader.ReadByte();
            ZoneLuminescentLagoon = flags[0];
            ZoneRuin = flags[1];
            ZonePlague = flags[2];
        }
        public override void CopyCustomBiomesTo(Player other)
        {
            OurStuffAddonPlayer modOther = other.GetModPlayer<OurStuffAddonPlayer>();
            modOther.ZoneRuin = ZoneRuin;
            modOther.ZoneLuminescentLagoon = ZoneLuminescentLagoon;
        }
        public override bool CustomBiomesMatch(Player other)
        {
            OurStuffAddonPlayer modOther = other.GetModPlayer<OurStuffAddonPlayer>();
            return ZoneRuin == modOther.ZoneRuin;
            return ZoneLuminescentLagoon == modOther.ZoneLuminescentLagoon;
            // If you have several Zones, you might find the &= operator or other logic operators useful:
            // bool allMatch = true;
            // allMatch &= ZoneExample == modOther.ZoneExample;
            // allMatch &= ZoneModel == modOther.ZoneModel;
            // return allMatch;
            // Here is an example just using && chained together in one statemeny 
            // return ZoneExample == modOther.ZoneExample && ZoneModel == modOther.ZoneModel;
        }
    }
}
