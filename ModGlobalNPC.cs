using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon
{
    public class ModGlobalNPC : GlobalNPC
{
    public override void NPCLoot(NPC npc)
    {
        //The if (Main.rand.Next(x) == 0) determines how rare the drop is. To find the percent of a drop, divide 100 by your desired percent, minus the percent sign. Ex: A 2% chance would be 100% / 2%, or 50. This is what you put in place of x.

        if (Main.rand.Next(4) == 0) //2% chance
        {
            if (npc.type == NPCID.Mothron)
                {
                Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height,  mod.ItemType("BrokenHeroBow"));
            }
        }
    }
}
}