using System.IO;
using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon
{
	public class MyPlayer : ModPlayer
	{
		public bool Tippi;
		public bool ShroomBuff;
		public bool SpiritPet;
		public bool BabyCactus;
		public bool blueSlime;

		public bool ZoneLuminescentLagoon;

		public bool ZoneRuin;

		public override void ResetEffects()
		{
			SpiritPet = false;
			Tippi = false;
			ShroomBuff = false;
			blueSlime = false;
			BabyCactus = false;
		}

		public override void UpdateBiomes()
		{
			ZoneLuminescentLagoon = MyWorld.LuminescentLagoon > 100;
			ZoneRuin = MyWorld.Ruin > 100;
		}

		public override void SendCustomBiomes(BinaryWriter writer)
		{
			BitsByte flags = new BitsByte();
			flags[0] = ZoneLuminescentLagoon;
			flags[1] = ZoneRuin;
			writer.Write(flags);
		}

		public override void ReceiveCustomBiomes(BinaryReader reader)
		{
			BitsByte flags = reader.ReadByte();
			ZoneLuminescentLagoon = flags[0];
			ZoneRuin = flags[1];
		}

		public override void CopyCustomBiomesTo(Player other)
		{
			MyPlayer modOther = other.GetModPlayer<MyPlayer>();
			modOther.ZoneRuin = ZoneRuin;
			modOther.ZoneLuminescentLagoon = ZoneLuminescentLagoon;
		}

		public override bool CustomBiomesMatch(Player other)
		{
			MyPlayer modOther = other.GetModPlayer<MyPlayer>();
			return ZoneRuin == modOther.ZoneRuin;
		}
	}
}