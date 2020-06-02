using System.IO;
using Terraria;
using Terraria.IO;
using Terraria.ModLoader;

namespace OurStuffAddon
{
	public static class Config
	{
		public static bool HeartStoneNotices = true;
		private static string ConfigPath = Path.Combine(Main.SavePath, "Mod Configs", "OurStuffAddonConfig.json");
		private static Preferences Configuration = new Preferences(ConfigPath);

		public static void Load()
		{
			bool success = ReadConfig();

			if (!success)
			{
				ErrorLogger.Log("Could not read OurStuffAddon's config file, creating new config file");
				CreateConfig();
			}
		}

		private static bool ReadConfig()
		{
			if (Configuration.Load())
			{
				Configuration.Get<bool>("Show 0.4 (HeartStone) Notices", ref Config.HeartStoneNotices);
				if (HeartStoneNotices != true && HeartStoneNotices != false)
				{
					ErrorLogger.Log("'Show 0.4 (HeartStone) Notices' was a value other than true/false, setting to true");
					HeartStoneNotices = true;
				}
				return true;
			}
			else
			{
				return false;
			}
		}

		private static void CreateConfig()
		{
			Configuration.Clear();
			Configuration.Put("Show 0.4 (HeartStone) Notices", HeartStoneNotices);
			Configuration.Save(true);
		}
	}
}