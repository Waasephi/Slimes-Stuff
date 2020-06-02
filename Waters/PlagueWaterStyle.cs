using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Waters
{
	public class PlagueWaterStyle : ModWaterStyle
	{
		public override bool ChooseWaterStyle()
		{
			return Main.bgStyle == mod.GetSurfaceBgStyleSlot("PlagueBackroundSurfaceStyle");
		}

		public override int ChooseWaterfallStyle()
		{
			return mod.GetWaterfallStyleSlot("PlagueWaterfallStyle");
		}

		public override int GetSplashDust()
		{
			return mod.DustType("PlagueWaterSplash");
		}

		public override int GetDropletGore()
		{
			return mod.GetGoreSlot("Gores/PlagueDroplet");
		}

		public override void LightColorMultiplier(ref float r, ref float g, ref float b)
		{
			r = 1f;
			g = 0f;
			b = 1f;
		}

		public override Color BiomeHairColor()
		{
			return Color.Purple;
		}
	}
}