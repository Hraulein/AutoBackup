using System;
using System.Text.Json.Serialization;

namespace AutoBackup.POJO
{
    class BackupItem
    {
        public BackupItem()
        {
            BackupSettings = new Config.BackupSettings();
            BackupSourcePath = "";
            LastBackupTime = null;
            Size = null;
        }
        /* 备份任务的单独设置,跟随全局请使用null */
        [JsonPropertyName("BackupSettings")]
        public Config.BackupSettings BackupSettings { get; set; }

        /* 备份的源路径 */
        [JsonPropertyName("SourcePath")]
        public string BackupSourcePath { get; set; }

        /* 上次备份时间(从未备份请使用null) */
        [JsonPropertyName("LastBackupTime")]
        public DateTime? LastBackupTime { get; set; }

        /* 备份的大小(请动态更新!!文件不存在请置为null) */
        [JsonPropertyName("Size")]
        public long? Size { get; set; }

        /* 备份的源类型(文件夹/文件) */
        [JsonPropertyName("BackupTaskType")]
        public EnumExtensions.BackupTaskType BackupTaskType { get; set; }
    }
}
