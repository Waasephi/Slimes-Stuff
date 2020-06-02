using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Waters
{
	public class LuminescentWaterStyle : ModWaterStyle
	{
		public override bool ChooseWaterStyle()
		{
			return Main.bgStyle == mod.GetSurfaceBgStyleSlot("LuminescentBackgroundSurfaceStyle");    //this is where u choose where the custom water/waterfalls will appear. it will appear in base of backgrounds so add your surface background name.
		}

		public override int ChooseWaterfallStyle()
		{
			return mod.GetWaterfallStyleSlot("LuminescentWaterfallStyle");   //this is the waterfall style
		}

		public override int GetSplashDust()
		{
			return mod.DustType("LuminescentDust");   //this is the water splash dust
		}

		public override int GetDropletGore()
		{
			return mod.GetGoreSlot("Gores/LuminescentWaterDroplet");     //this is the water droplet
		}

		public override void LightColorMultiplier(ref float r, ref float g, ref float b)
		{
			r = 1f;
			g = 1f;
			b = 1f;
		}

		public override Color BiomeHairColor()
		{
			return Color.White;
		}
	}
}