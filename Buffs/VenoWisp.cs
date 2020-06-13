using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace OurStuffAddon.Buffs
{
	public class VenoWisp : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Veno Wisp");
			Description.SetDefault("A Venom wisp will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			OurStuffAddonPlayer modPlayer = player.GetModPlayer<OurStuffAddonPlayer>();
			if (player.ownedProjectileCounts[ProjectileType<Projectiles.Minions.VenoWisp>()] > 0)
			{
				modPlayer.VenoWisp = true;
			}
			if (!modPlayer.VenoWisp)
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