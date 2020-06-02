using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon.Items.Ranged.Ammo
{
    public class PhoenixSolution : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Flare Solution");
        }

        public override void SetDefaults()
        {
            item.shoot = mod.ProjectileType("FlareSolution") - ProjectileID.PureSpray;
            item.ammo = AmmoID.Solution;
            item.width = 10;
            item.height = 12;
            item.value = Item.buyPrice(0, 0, 25, 0);
            item.rare = 3;
            item.maxStack = 999;
            item.consumable = true;
        }
    
    }



}