using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Waters
{
	public class PlagueWaterStyle : ModWaterStyle
	{
		public override bool ChooseWaterStyle()
			=> Main.bgStyle == mod.GetSurfaceBgStyleSlot("PlagueBackroundSurfaceStyle");

		public override int ChooseWaterfallStyle()
			=> mod.GetWaterfallStyleSlot("PlagueWaterfallStyle");

		public override int GetSplashDust()
			=> mod.DustType("PlagueWaterSplash");

		public override int GetDropletGore()
			=> mod.GetGoreSlot("Gores/PlagueDroplet");

		public override void LightColorMultiplier(ref float r, ref float g, ref float b)
		{
			r = 1f;
			g = 0f;
			b = 1f;
		}

		public override Color BiomeHairColor()
			=> Color.Purple;
	}
}