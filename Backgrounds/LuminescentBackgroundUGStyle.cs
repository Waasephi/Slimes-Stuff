using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Backgrounds
{
	public class LuminescentBackgroundUG : ModUgBgStyle
	{
		public override bool ChooseBgStyle()
		{
			return Main.LocalPlayer.GetModPlayer<MyPlayer>().ZoneLuminescentLagoon;
		}

		public override void FillTextureArray(int[] textureSlots)
		{
			textureSlots[0] = mod.GetBackgroundSlot("Backgrounds/LagoonUG0");
			textureSlots[1] = mod.GetBackgroundSlot("Backgrounds/LagoonUG1");
			textureSlots[2] = mod.GetBackgroundSlot("Backgrounds/LagoonUG2");
			textureSlots[3] = mod.GetBackgroundSlot("Backgrounds/LagoonUG3");
		}
	}
}