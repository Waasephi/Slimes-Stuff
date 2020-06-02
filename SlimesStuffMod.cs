using ReLogic.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace OurStuffAddon
{
	public class SlimesStuffMod : Mod
	{
		public static SlimesStuffMod Instance => ModContent.GetInstance<SlimesStuffMod>();

		public override void UpdateMusic(ref int music, ref MusicPriority priority)
		{
			if (Main.myPlayer == -1 || Main.gameMenu || !Main.LocalPlayer.active)
				return;

			// Make sure your logic here goes from lowest priority to highest so your intended priority is maintained.
			if (Main.LocalPlayer.GetModPlayer<MyPlayer>().ZoneLuminescentLagoon)
			{
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/LuminescentLagoon");
				priority = MusicPriority.BiomeHigh;
			}
			if (Main.LocalPlayer.GetModPlayer<MyPlayer>().ZoneRuin)
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

			RecipeGroup TrueEvilBlaster = new RecipeGroup(() => Lang.misc[37] + " True Evil Blaster", new int[]
			{
				ItemType("TrueNoctem"),
				ItemType("TrueClotCannon"),
			});
			RecipeGroup.RegisterGroup("OurStuffAddon:TrueEvilBlaster", TrueEvilBlaster);

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

		}

		public override void PostSetupContent()
		{
			Mod bossChecklist = ModLoader.GetMod("BossChecklist");

			if (bossChecklist != null)
			{
				bossChecklist.Call("AddBossWithInfo", "Giant Sand Sifter", 2.001f, (Func<bool>)(() => MyWorld.downedGiantSandSifter), string.Format("Use [i:{0}] in the desert", ItemType("SandEmblem")));
				bossChecklist.Call("AddBossWithInfo", "Life Enforcer", 2.001f, (Func<bool>)(() => MyWorld.downedLifeEnforcer), string.Format("Use [i:{0}] underground", ItemType("CrystalHeart")));
				bossChecklist.Call("AddBossWithInfo", "Cosmic Slime", 15.001f, (Func<bool>)(() => MyWorld.downedCosmicSlime), string.Format("Use [i:{0}] anytime, anywhere.", ItemType("CosmicStarMesh")));
				bossChecklist.Call("AddBossWithInfo", "Neo Mothership", 5.001f, (Func<bool>)(() => MyWorld.downedNeoMothership), string.Format("Use [i:{0}] anytime, anywhere.", ItemType("NeoLocator")));
				bossChecklist.Call("AddBossWithInfo", "Ancient Observer", 4.001f, (Func<bool>)(() => MyWorld.downedAncientObserver), string.Format("Use [i:{0}] anytime, in the ruin.", ItemType("RelicPebble")));
			}
		}
	}
}