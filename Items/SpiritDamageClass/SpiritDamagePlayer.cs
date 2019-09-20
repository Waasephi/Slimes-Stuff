using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.SpiritDamageClass
{
    // This class stores necessary player info for our custom damage class, such as damage multipliers and additions to knockback and crit.
    public class SpiritDamagePlayer : ModPlayer
    {
        public static SpiritDamagePlayer ModPlayer(Player player)
        {
            return player.GetModPlayer<SpiritDamagePlayer>();
        }

        // Vanilla only really has damage multipliers in code
        // And crit and knockback is usually just added to
        // As a modder, you could make separate variables for multipliers and simple addition bonuses
        public float spiritDamageAdd;
        public float spiritDamageMult = 1f;
        public float spiritKnockback;
        public int spiritCrit;

        public override void ResetEffects()
        {
            ResetVariables();
        }

        public override void UpdateDead()
        {
            ResetVariables();
        }

        private void ResetVariables()
        {
            spiritDamageAdd = 0f;
            spiritDamageMult = 1f;
            spiritKnockback = 0f;
            spiritCrit = 0;
        }
    }
}