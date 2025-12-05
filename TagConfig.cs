using System;
using System.Collections.Generic;
using System.Text;

namespace TagUtils
{
    public class TagConfig
    {
        public TagConfig()
        {
            ConfigVersion = TagUtilsMain.TAGUTILS_VERSION;
            LastUsedTagPath = null;
		}

		public TagConfig(string configVersion, string lastUsedTagPath)
        {
            ConfigVersion = configVersion;
            LastUsedTagPath = lastUsedTagPath;
        }

        public string? ConfigVersion { get; set; }
		public string? LastUsedTagPath { get; set; }

        public static TagConfig LoadConfig(string path)
        {
            if (!File.Exists(path))
            {
                return new TagConfig();
            }
            string json = File.ReadAllText(path);
            return System.Text.Json.JsonSerializer.Deserialize<TagConfig>(json) ?? new TagConfig();
		}

        public static void SaveConfig(string configPath, TagConfig config)
        {
            string json = System.Text.Json.JsonSerializer.Serialize(config, new System.Text.Json.JsonSerializerOptions() { WriteIndented = true });

            if (!Directory.Exists(Path.GetDirectoryName(configPath)!))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(configPath)!);
			}

			File.WriteAllText(configPath, json);
		}
    }
}
