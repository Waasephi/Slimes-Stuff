using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.NPCs.Bosses
{
    public class SpiritBlast : ModNPC
    {
        float _theta = -1;
        float _dist = 0;
        float _distRate = 1;
        public override void SetDefaults()
        {
            _distRate = 1;
            _dist = 20;
            _theta = -1;
            npc.width = 30;
            npc.height = 30;
            npc.damage = 50;
            npc.defense = 12;
            npc.lifeMax = 4500;
            npc.value = 0f;
            npc.knockBackResist = 0f;
            npc.aiStyle = 0;
            npc.lavaImmune = true;
            npc.noGravity = true;
            npc.noTileCollide = true;
            npc.buffImmune[24] = true;
            npc.dontTakeDamage = true;
            npc.scale = 1.5f;
        }

        public override void OnHitPlayer(Player target, int dmgDealt, bool crit)
        {
            target.AddBuff(BuffID.Frostburn, 300, true);
        }

        public override void AI()
        {
            if (_theta == -1)
                _theta = npc.ai[1] * 6.28f / 8;
            _theta += 3.14f / 80;
            _dist += _distRate;
            _distRate += .05f;
            float divisions = 6.28f / 8;
            Vector2 targetPos;
            targetPos.X = Main.npc[(int)npc.ai[0]].Center.X + _dist * (float)Math.Cos(_theta) - npc.width / 2;
            targetPos.Y = Main.npc[(int)npc.ai[0]].Center.Y + _dist * (float)Math.Sin(_theta);
            npc.position = targetPos;
            if (_dist > 1600)
            {
                npc.active = false;
                npc.life = 0;
            }
        }

    }
}