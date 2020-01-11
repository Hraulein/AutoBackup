using System;
using System.Text.Json.Serialization;

namespace AutoBackup.POJO
{
    class BackupItem
    {
        
        [JsonPropertyName("BackupList")]
        public Config.BackupSettings BackupSettings { get; set; }

        [JsonPropertyName("SourcePath")]
        public string BackuoSourcePath { get; set; }

        [JsonPropertyName("LastBackupTime")]
        public DateTime LastBackupTime { get; set; }

        [JsonPropertyName("Size")]
        public long Size { get; set; }

        [JsonPropertyName("BackupTaskType")]
        public EnumExtensions.BackupTaskType BackupTaskType { get; set; }
    }
}
