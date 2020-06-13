using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Backgrounds
{
	public class PhoenixBackgroundUG : ModUgBgStyle
	{
		public override bool ChooseBgStyle()
		{
			return Main.LocalPlayer.GetModPlayer<OurStuffAddonPlayer>().ZonePhoenix;
		}

		public override void FillTextureArray(int[] textureSlots)
		{
			textureSlots[0] = mod.GetBackgroundSlot("Backgrounds/PhoenixUG0");
			textureSlots[1] = mod.GetBackgroundSlot("Backgrounds/PhoenixUG1");
			textureSlots[2] = mod.GetBackgroundSlot("Backgrounds/PhoenixUG2");
			textureSlots[3] = mod.GetBackgroundSlot("Backgrounds/PhoenixUG3");
		}
	}
}