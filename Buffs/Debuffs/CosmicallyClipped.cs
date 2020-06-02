using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Buffs.Debuffs
{
	public class CosmicallyClipped : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Cosmically Clipped");
			Description.SetDefault("You Cannot fly.");
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
			canBeCleared = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.wingTimeMax = -1;
		}
	}
}