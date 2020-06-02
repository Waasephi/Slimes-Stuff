using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Buffs
{
	public class BlueSlime : ModBuff
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
			if (player.ownedProjectileCounts[mod.ProjectileType("BlueSlime")] > 0)
			{
				modPlayer.blueSlime = true;
			}
			if (!modPlayer.blueSlime)
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