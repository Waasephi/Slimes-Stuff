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
using OurStuffAddon.Items.MusicBoxes;
using OurStuffAddon.Tiles.MusicBoxes;
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
        public override void Load()
        {

            if (!Main.dedServ)
            {
                // Register a new music box
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/LuminescentLagoon"), ItemType("Luminescent"), TileType("Luminescent"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/GiantSandSifterTheme"), ItemType("GiantSandSifter"), TileType("GiantSandSifter"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/LifeEnforcerTheme"), ItemType("LifeEnforcer"), TileType("LifeEnforcer"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Ruin"), ItemType("Ruin"), TileType("Ruin"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/AncientObserverTheme"), ItemType("AncientObserver"), TileType("AncientObserver"));
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/NeoParasiteTheme"), ItemType("NeoParasite"), TileType("NeoParasite"));

                // Change the vanilla loom texture
                //Main.instance.LoadTiles(TileID.Loom); // First load the tile texture
                //Main.tileTexture[TileID.Loom] = GetTexture("Tiles/AnimatedLoom"); // Now we change it

                //What if....Replace a vanilla item texture and equip texture.
                //Main.itemTexture[ItemID.CopperHelmet] = GetTexture("Resprite/CopperHelmet_Item");
                //Item copperHelmet = new Item();
                //copperHelmet.SetDefaults(ItemID.CopperHelmet);
                //Main.armorHeadLoaded[copperHelmet.headSlot] = true;
                //Main.armorHeadTexture[copperHelmet.headSlot] = GetTexture("Resprite/CopperHelmet_Head");
            }
          /*  Mod yabhb = ModLoader.GetMod("FKBossHealthBar");
            if (yabhb != null)
            {
                yabhb.Call("hbStart");
                yabhb.Call("hbSetTexture",
                    GetTexture("UI/LEHBStart"),
                    GetTexture("UI/LEHBMiddle"),
                    GetTexture("UI/LEHBEnd"),
                    GetTexture("UI/LEHBFill"));
                yabhb.Call("hbSetMidBarOffset", 20, 10);
                yabhb.Call("hbSetBossHeadCentre", 22, 44);
                yabhb.Call("hbSetFillDecoOffsetSmall", 16);
                yabhb.Call("hbFinishSingle", mod,"LifeEnforcer");
            }*/
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
            if (Main.LocalPlayer.GetModPlayer<OurStuffAddonPlayer>().ZonePhoenix)
            {
                if (Main.player[Main.myPlayer].ZoneRockLayerHeight)
                {
                    music = GetSoundSlot(SoundType.Music, "Sounds/Music/PhoenixUnderground");
                    priority = MusicPriority.BiomeHigh;
                }
                else;
                music = GetSoundSlot(SoundType.Music, "Sounds/Music/PhoenixUnderground");
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

            RecipeGroup TrueEvilDagger = new RecipeGroup(() => Lang.misc[37] + " True Evil Dagger", new int[]
            {
                ItemType("TrueNightDagger"),
                ItemType("TrueClotDagger"),
            });

            RecipeGroup.RegisterGroup("OurStuffAddon:TrueEvilDagger", TrueEvilDagger);



            RecipeGroup TrueEvilBlaster = new RecipeGroup(() => Lang.misc[37] + " Evil Gun", new int[]
            {
                ItemType("BloodyMusket"),
                ItemType("CorruptRevolver"),
            });
            RecipeGroup.RegisterGroup("OurStuffAddon:EvilGun", TrueEvilBlaster);
            RecipeGroup EvilBar = new RecipeGroup(() => Lang.misc[37] + " Evil Bar", new int[]
            {
                ItemID.DemoniteBar,
                ItemID.CrimtaneBar
            });
            RecipeGroup.RegisterGroup("OurStuffAddon:EvilBar", EvilBar);

            RecipeGroup EvilMaterial = new RecipeGroup(() => Lang.misc[37] + " Evil Material", new int[]
            {

                ItemID.ShadowScale,
                ItemID.TissueSample
            });
            RecipeGroup.RegisterGroup("OurStuffAddon:EvilMaterial", EvilMaterial);

            RecipeGroup EvilRod = new RecipeGroup(() => Lang.misc[37] + " Evil Rod", new int[]
{
                ItemType("BloodRod"),
                ItemType("CursedRod"),
});
            RecipeGroup.RegisterGroup("OurStuffAddon:EvilRod", EvilRod);
            RecipeGroup EvilStaff = new RecipeGroup(() => Lang.misc[37] + " Evil Staff", new int[]
{
                ItemType("CrimStaff"),
                ItemType("CorroStaff"),
});
            RecipeGroup.RegisterGroup("OurStuffAddon:EvilStaff", EvilStaff);
            RecipeGroup Anvils = new RecipeGroup(() => Lang.misc[37] + " Pre Hardmode Anvil", new int[]
{
                ItemID.IronAnvil,
                ItemID.LeadAnvil
});
            RecipeGroup.RegisterGroup("OurStuffAddon:Anvils", Anvils);

        }



        //BossChecklist
        public override void PostSetupContent()
        {
            Mod bossChecklist = ModLoader.GetMod("BossChecklist");

            if (bossChecklist != null)
            {
                bossChecklist.Call("AddBossWithInfo", "Giant Sand Sifter", 2.001f, (Func<bool>)(() => OurStuffAddonWorld.downedGiantSandSifter), string.Format("Use [i:{0}] in the underground desert", ItemType("SandEmblem")));
                bossChecklist.Call("AddBossWithInfo", "Life Enforcer", 2.001f, (Func<bool>)(() => OurStuffAddonWorld.downedLifeEnforcer), string.Format("Use [i:{0}] underground", ItemType("CrystalHeart")));
                bossChecklist.Call("AddBossWithInfo", "Cosmic Slime", 15.001f, (Func<bool>)(() => OurStuffAddonWorld.downedCosmicSlime), string.Format("Use [i:{0}] anytime, anywhere.", ItemType("CosmicStarMesh")));
                bossChecklist.Call("AddBossWithInfo", "Neo Mothership", 5.001f, (Func<bool>)(() => OurStuffAddonWorld.downedNeoMothership), string.Format("Use [i:{0}] anytime, anywhere.", ItemType("NeoLocator")));
                bossChecklist.Call("AddBossWithInfo", "Ancient Observer", 4.001f, (Func<bool>)(() => OurStuffAddonWorld.downedAncientObserver), string.Format("Use [i:{0}] anytime, in the ruin.", ItemType("RelicPebble")));
            }
            Mod bossAssist = ModLoader.GetMod("BossAssist");
            if (bossAssist != null)
            {
                bossAssist.Call("AddBoss", NPCType("GiantSandSifter"), "returned to the sands");
                bossAssist.Call("AddBoss", NPCType("LifeEnforcer"), "has completed its goal");
                bossAssist.Call("AddBoss", NPCType("NeoMothership"), "returned to the skies");
                bossAssist.Call("AddBoss", NPCType("NeoParasite"), "returned to its mothership");
                bossAssist.Call("AddBoss", NPCType("CosmicSlime"), "returned to the cosmos");
                bossAssist.Call("AddBoss", NPCType("AncientObserver"), "dissipated into the void");
                // Example - bossAssist.Call("AddBoss", NPCType("WolfBoss"), " has tainted the heroes");
                /* List<int> BossLoot = new List<int>()
                 {
                     ItemType("CosmicSlimeTreasureBag"), // Order does not matter NEXT UPDATE (v1.2)
                     ItemType("CosmicCore"),
                     ItemType("CosmicFragment"),
                 };
                     bossAssist.Call("AddStatPage",
                         1f, // This is progression  position. Refer to Boss Checklist's prog list
                         NPCType("CosmicSlime"), // NPC ID
                         Name, // Internal name of your mod
                         "Cosmic Slime",
                         (Func<bool>)(() => OurStuffAddonWorld.downedCosmicSlime), // Downed boss bool
                         ItemType("CosmicStarMesh"), // Spawn Item
                         BossCollection,
                         BossLoot,
                         "CosmicSlime"); // I need a single frame of your boss, a wiki image for example inside your mo*/
            }
        }
    }
}



