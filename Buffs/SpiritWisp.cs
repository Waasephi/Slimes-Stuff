using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace OurStuffAddon.Buffs
{
	public class SpiritWisp : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Spirit Wisp");
			Description.SetDefault("A spirit wisp will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			MyPlayer modPlayer = player.GetModPlayer<MyPlayer>();
			if (player.ownedProjectileCounts[ProjectileType<Projectiles.Minions.SpiritWisp>()] > 0)
			{
				modPlayer.SpiritWisp = true;
			}
			if (!modPlayer.SpiritWisp)
			{
				player.DelBuff(buffIndex);
				buffIndex--;
			}
			else
			{
				player.buffTime[buffIndex] = 18000;
			}
		}
	}
}