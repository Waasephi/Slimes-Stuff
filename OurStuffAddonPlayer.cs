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

        public float cactusDamage = 1f;
        public override void ResetEffects()
        {
            SpiritPet = false;
            Tippi = false;
            ShroomBuff = false;
            cactusDamage = 1f;
            blueSlime = false;
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
            flags[0] = ZoneRuin;
            flags[0] = ZonePlague;
            writer.Write(flags);
        }
        public override void ReceiveCustomBiomes(BinaryReader reader)
        {
            BitsByte flags = reader.ReadByte();
            ZoneLuminescentLagoon = flags[0];
            ZoneRuin = flags[0];
            ZonePlague = flags[0];
        }
    }
}
