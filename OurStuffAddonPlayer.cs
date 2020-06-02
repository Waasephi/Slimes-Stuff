using System;
using System.Collections.Generic;
using System.IO;
using OurStuffAddon.Buffs;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.GameInput;

namespace OurStuffAddon
{
    public partial class OurStuffAddonPlayer : ModPlayer
    {
        public bool Tippi;
        public bool ShroomBuff;
        public bool SpiritWisp;
        public bool TrueSpiritWisp;
        public bool StardustWisp;
        public bool BloodWisp;
        public bool CursedWisp;
        public bool InfernalWisp;
        public bool VenoWisp;
        public bool HalloCross;
        public bool ChloroBulb;
        public bool SpiritPet;
        public bool BabyCactus;
        public bool blueSlime;
        public bool sifter;
        public bool sifter2;

        public override void ResetEffects()
        {
            SpiritPet = false;
            Tippi = false;
            ShroomBuff = false;
            ChloroBulb = false;
            SpiritWisp = false;
            StardustWisp = false;
            TrueSpiritWisp = false;
            InfernalWisp = false;
            HalloCross = false;
            VenoWisp = false;
            BloodWisp = false;
            CursedWisp = false;
            blueSlime = false;
            BabyCactus = false;
            sifter = false;
            sifter2 = false;
            Obsidiflame = false;
        }

     /*   public override void OnHitNPC(Item item, NPC target, int damage, float knockback, bool crit)
        {
            if (!NoDebuffDamage)
                InflictDebuffs(item, target, damage, knockback, crit);
        }

        private void InflictDebuffs(Item item, NPC target, int damage, float knockback, bool crit)
        {
            int rand = Main.rand.Next(2);
            if (Obsidiflame)
                target.AddBuff(ModContent.BuffType<Obsidiflame>(), (int)((60 * rand)), false);
        }*/
        public bool ZoneLuminescentLagoon;
        public bool ZonePhoenix;
        public bool ZoneRuin;
        public override void UpdateBiomes()
        {
            ZoneLuminescentLagoon = OurStuffAddonWorld.LuminescentLagoon > 100;
            ZoneRuin = OurStuffAddonWorld.Ruin > 100;
            ZonePhoenix = OurStuffAddonWorld.Phoenix > 200;
        }
        public override void SendCustomBiomes(BinaryWriter writer)
        {
            BitsByte flags = new BitsByte();
            flags[0] = ZoneLuminescentLagoon;
            flags[1] = ZoneRuin;
            flags[2] = ZonePhoenix;
            writer.Write(flags);
        }
        public override void ReceiveCustomBiomes(BinaryReader reader)
        {
            BitsByte flags = reader.ReadByte();
            ZoneLuminescentLagoon = flags[0];
            ZoneRuin = flags[1];
            ZonePhoenix = flags[2];
        }
        public override void CopyCustomBiomesTo(Player other)
        {
            OurStuffAddonPlayer modOther = other.GetModPlayer<OurStuffAddonPlayer>();
            modOther.ZoneRuin = ZoneRuin;
            modOther.ZonePhoenix = ZonePhoenix;
            modOther.ZoneLuminescentLagoon = ZoneLuminescentLagoon;
        }
        public override bool CustomBiomesMatch(Player other)
        {
            OurStuffAddonPlayer modOther = other.GetModPlayer<OurStuffAddonPlayer>();
            return ZoneRuin == modOther.ZoneRuin;
            return ZonePhoenix == modOther.ZonePhoenix;
            return ZoneLuminescentLagoon == modOther.ZoneLuminescentLagoon;
            // If you have several Zones, you might find the &= operator or other logic operators useful:
            // bool allMatch = true;
            // allMatch &= ZoneExample == modOther.ZoneExample;
            // allMatch &= ZoneModel == modOther.ZoneModel;
            // return allMatch;
            // Here is an example just using && chained together in one statemeny 
            // return ZoneExample == modOther.ZoneExample && ZoneModel == modOther.ZoneModel;

        } 
        #region Buffs
        public bool Obsidiflame { get; set; }
        #endregion
    }
}
