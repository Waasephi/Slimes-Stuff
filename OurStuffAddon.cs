using Terraria;
using Terraria.Graphics.Effects;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using OurStuffAddon.Items.SpiritDamageClass;
using Terraria;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace OurStuffAddon
{
    class OurStuffAddon : Mod
    {
        public static ModHotKey RandomBuffHotKey;
        public static int FaceCustomCurrencyId;
        // With the new fonts in 1.3.5, font files are pretty big now so you need to generate the font file before building the mod.
        // You can use https://forums.terraria.org/index.php?threads/dynamicspritefontgenerator-0-4-generate-fonts-without-xna-game-studio.57127/ to make dynamicspritefonts
        public static DynamicSpriteFont exampleFont;
        internal static OurStuffAddon Instance;

        private UserInterface _exampleUserInterface;

        internal UserInterface ExamplePersonUserInterface;

        // Your mod instance has a Logger field, use it.
        // OPTIONAL: You can create your own logger this way, recommended is a custom logging class if you do a lot of logging
        // You need to reference the log4net library to do this, this can be found in the tModLoader repository
        // inside the references folder. You do not have to add this to build.txt as tML has it natively.
        // internal ILog Logging = LogManager.GetLogger("ExampleMod");

        public OurStuffAddon()
        {
            Instance = this;
            // By default, all Autoload properties are True. You only need to change this if you know what you are doing.
            //Properties = new ModProperties()
            //{
            //	Autoload = true,
            //	AutoloadGores = true,
            //	AutoloadSounds = true,
            //	AutoloadBackgrounds = true
            //};
        }
        public static OurStuffAddon instance;
        public override void UpdateMusic(ref int music, ref MusicPriority priority)
        {
            if (Main.myPlayer == -1 || Main.gameMenu || !Main.LocalPlayer.active)
            {
                return;
            }

            // Make sure your logic here goes from lowest priority to highest so your intended priority is maintained.
            if (Main.LocalPlayer.GetModPlayer<OurStuffAddonPlayer>().ZoneLuminescentLagoon)
            {
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/LuminescentLagoon");
                priority = MusicPriority.BiomeHigh;
            }
            if (Main.LocalPlayer.GetModPlayer<OurStuffAddonPlayer>().ZoneRuin)
            {
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/Ruin");
                priority = MusicPriority.BiomeHigh;
            }
        }
        public override void AddRecipeGroups()
        {
            RecipeGroup EvilBlade = new RecipeGroup(() => Lang.misc[37] + " Evil Blade", new int[]
            {
                ItemType("DemonBlade"),
                ItemType("Crimblade"),
            });

            RecipeGroup.RegisterGroup("OurStuffAddon:EvilBlade", EvilBlade);
            RecipeGroup EvilGem = new RecipeGroup(() => Lang.misc[37] + " Evil Gem", new int[]
{
                ItemType("CorroGem"),
                ItemType("CrimGem"),
});
            RecipeGroup.RegisterGroup("OurStuffAddon:EvilGem", EvilGem);

            RecipeGroup TrueEvilJavelin = new RecipeGroup(() => Lang.misc[37] + " True Evil Javelin", new int[]
            {
                ItemType("TrueNightJavelin"),
                ItemType("TrueClotJavelin"),
            });

            RecipeGroup.RegisterGroup("OurStuffAddon:TrueEvilJavelin", TrueEvilJavelin);

            RecipeGroup TrueEvilBlaster = new RecipeGroup(() => Lang.misc[37] + " True Evil Blaster", new int[]
            {
                ItemType("TrueNoctem"),
                ItemType("TrueClotCannon"),
            });

            RecipeGroup.RegisterGroup("OurStuffAddon:TrueEvilBlaster", TrueEvilBlaster);
            RecipeGroup EvilBar = new RecipeGroup(() => Lang.misc[37] + " Evil Bar", new int[]
{
                ItemType("DemoniteBar"),
                ItemType("CrimtaneBar"),
});

            RecipeGroup.RegisterGroup("OurStuffAddon:EvilBar", EvilBar);

        }
        //BossChecklist
        public override void PostSetupContent()
        {
            Mod bossChecklist = ModLoader.GetMod("BossChecklist");

            if (bossChecklist != null)
            {
                bossChecklist.Call("AddBossWithInfo", "Giant Sand Sifter", 1.001f, (Func<bool>)(() => OurStuffAddonWorld.downedGiantSandSifter), string.Format("Use [i:{0}] in the desert", ItemType("SandEmblem")));
                bossChecklist.Call("AddBossWithInfo", "Life Enforcer", 2.001f, (Func<bool>)(() => OurStuffAddonWorld.downedLifeEnforcer), string.Format("Use [i:{0}] underground", ItemType("CrystalHeart")));
                bossChecklist.Call("AddBossWithInfo", "Cosmic Slime", 15.001f, (Func<bool>)(() => OurStuffAddonWorld.downedCosmicSlime), string.Format("Use [i:{0}] anytime, anywhere.", ItemType("CosmicStarMesh")));
                bossChecklist.Call("AddBossWithInfo", "Neo Mothership", 5.001f, (Func<bool>)(() => OurStuffAddonWorld.downedNeoMothership), string.Format("Use [i:{0}] anytime, anywhere.", ItemType("NeoLocator")));
            }
        }
    }
}


		
