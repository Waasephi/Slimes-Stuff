using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace OurStuffAddon.Buffs
{
	public class ShroomBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Shroomy");
			Description.SetDefault("The mushrooms will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			MyPlayer modPlayer = player.GetModPlayer<MyPlayer>();

			if (player.ownedProjectileCounts[ProjectileType<Projectiles.Minions.Shroomy>()] > 0)
				modPlayer.ShroomBuff = true;
			
			if (!modPlayer.ShroomBuff)
			{
				player.DelBuff(buffIndex);
				buffIndex--;
			}
			else
				player.buffTime[buffIndex] = 18000;
		}
	}
}