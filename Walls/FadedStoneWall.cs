using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace OurStuffAddon.Walls
{
    public class FadedStoneWall : ModWall
    {
        public override void SetDefaults()
        {
            Main.wallHouse[Type] = true;
            dustType = mod.DustType("Sparkle");
            drop = mod.ItemType("FadedStoneWall");
            AddMapEntry(new Color(238, 232, 170));
        }

        public override void NumDust(int i, int j, bool fail, ref int num)
        {
            num = fail ? 1 : 3;
        }

        public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
        {
            r = 0.4f;
            g = 0.4f;
            b = 0.4f;
        }
    }
}