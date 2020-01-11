using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AutoBackup.POJO
{
    


    class Config
    {
        public class BackupSettings
        {
            [JsonPropertyName("Path")]
            public string Path { get; set; }

            [JsonPropertyName("Enable")]
            public bool Enable { get; set; }

            [JsonConverter(typeof(JsonStringEnumConverter))]
            [JsonPropertyName("BackupType")]
            public EnumExtensions.BackupType BackupType { get; set; }

        }


        public Config()
        {
            BackupItemsList = new List<BackupItem>();
        }


        [JsonPropertyName("GlobalSettingsBackup")]
        public BackupSettings GlobalBackupSettings { get; set; }

        [JsonPropertyName("BackupList")]
        public List<BackupItem> BackupItemsList { get; set; }
    }
}

