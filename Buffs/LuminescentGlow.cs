using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Buffs
{
	public class LuminescentGlow : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Luminescent Glow");
			Description.SetDefault("Shine Brightly");
			Main.buffNoTimeDisplay[Type] = false;
			Main.buffNoSave[Type] = true;
			canBeCleared = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			OurStuffAddonPlayer p = player.GetModPlayer<OurStuffAddonPlayer>();
			// Some other effects:
			//player.lifeRegen++;
			//player.meleeCrit += 2;
			Lighting.AddLight((int)(player.position.X + (float)(player.width / 2)) / 16, (int)(player.position.Y + (float)(player.height / 2)) / 16, 0f, 4f, 2f);
			//player.meleeSpeed += 0.051f;
			//player.statDefense += 3;
			//player.moveSpeed += 0.05f;
		}
	}
}