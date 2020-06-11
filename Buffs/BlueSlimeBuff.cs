using OurStuffAddon.Projectiles.Minions;
using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Buffs
{
	public class BlueSlimeBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Blue Slime");
			Description.SetDefault("The blue slime will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			MyPlayer modPlayer = player.GetModPlayer<MyPlayer>();

			if (player.ownedProjectileCounts[ModContent.ProjectileType<BlueSlimeProjectile>()] > 0)
			
			if (!modPlayer.blueSlime)
			{
				player.DelBuff(buffIndex);
				buffIndex--;
			}
			else
				player.buffTime[buffIndex] = 18000;
		}
	}
}