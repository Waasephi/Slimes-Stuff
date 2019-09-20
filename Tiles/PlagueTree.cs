using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader;

namespace OurStuffAddon.Tiles
{
    public class PlagueTree : ModTree
    {
        private Mod mod => ModLoader.GetMod("OurStuffAddon");

        public override int DropWood()
        {
            return mod.ItemType("PlagueWood");
        }

        public override Texture2D GetTexture()
        {
            return mod.GetTexture("Tiles/PlagueTree");
        }

        public override Texture2D GetTopTextures(int i, int j, ref int frame, ref int frameWidth, ref int frameHeight, ref int xOffsetLeft, ref int yOffset)
        {
            return mod.GetTexture("Tiles/PlagueTree_Tops");
        }

        public override Texture2D GetBranchTextures(int i, int j, int trunkOffset, ref int frame)
        {
            return mod.GetTexture("Tiles/PlagueTree_Branches");
        }
    }
}