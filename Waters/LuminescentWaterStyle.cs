using Microsoft.Xna.Framework;
using OurStuffAddon.Dusts;
using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Waters
{
	public class LuminescentWaterStyle : ModWaterStyle
	{
		public override bool ChooseWaterStyle()
		{
			//this is where u choose where the custom water/waterfalls will appear. it will appear in base of backgrounds so add your surface background name.
			return Main.bgStyle == mod.GetSurfaceBgStyleSlot("LuminescentBackgroundSurfaceStyle");
		}

		public override int ChooseWaterfallStyle()
		{
			//this is the waterfall style
			return mod.GetWaterfallStyleSlot("LuminescentWaterfallStyle");
		}

		public override int GetSplashDust()
		{
			//this is the water splash dust
			return ModContent.DustType<LuminescentDust>();
		}

		public override int GetDropletGore()
		{
			//this is the water droplet
			return mod.GetGoreSlot("Gores/LuminescentWaterDroplet"); 
		}

		public override void LightColorMultiplier(ref float r, ref float g, ref float b)
		{
			r = 1f;
			g = 1f;
			b = 1f;
		}

		public override Color BiomeHairColor() => Color.White;
	}
}