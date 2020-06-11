using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Dusts
{
	public class SeafoamDust : ModDust
	{
		public override void SetDefaults()
		{
			updateType = 33;
		}

		public override void OnSpawn(Dust dust)
		{
			dust.alpha = 1; //this is the dust visibiliti, the bigger is the value less visible
			dust.velocity *= 1f; //this is the velocity of dust
			dust.velocity.Y += 1f; //and this is the velocity of dust when it goes up
		}
	}
}