using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Buffs
{
	public class ThrowingPowerPotionBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Throwing Power");
			Description.SetDefault("Throwing damage is increased");
			Main.buffNoTimeDisplay[Type] = false;
			Main.buffNoSave[Type] = true;
			canBeCleared = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.thrownDamage *= 1.2f;
		}
	}
}