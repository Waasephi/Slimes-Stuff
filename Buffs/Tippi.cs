using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace OurStuffAddon.Buffs
{
	public class Tippi : ModBuff
	{
		public override void SetDefaults()
		{
			// DisplayName and Description are automatically set from the .lang files, but below is how it is done normally.
			DisplayName.SetDefault("Tippi");
			Description.SetDefault("It seems like they've been on a wonderous adventure!");
			Main.buffNoTimeDisplay[Type] = true;
			Main.vanityPet[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.buffTime[buffIndex] = 18000;
			player.GetModPlayer<OurStuffAddonPlayer>().Tippi = true;
			bool petProjectileNotSpawned = player.ownedProjectileCounts[ProjectileType<Projectiles.Pets.Tippi>()] <= 0;
			if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
			{
				Projectile.NewProjectile(player.position.X + player.width / 2, player.position.Y + player.height / 2, 0f, 0f, mod.ProjectileType("Tippi"), 0, 0f, player.whoAmI, 0f, 0f);
			}
		}
	}
}