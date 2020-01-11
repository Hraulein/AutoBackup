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

        /// <summary>
        /// 备份任务的单独设置, 跟随全局请使用null
        /// </summary>
        [JsonPropertyName("BackupSettings")]
        public Config.BackupSettings BackupSettings { get; set; }

        /// <summary>
        /// 备份的源路径
        /// </summary>
        [JsonPropertyName("SourcePath")]
        public string BackupSourcePath { get; set; }

        /// <summary>
        /// 上次备份时间(从未备份请使用null)
        /// </summary>
        [JsonPropertyName("LastBackupTime")]
        public DateTime? LastBackupTime { get; set; }

        /// <summary>
        /// 备份的大小(请动态更新!!文件不存在请置为null)
        /// </summary>
        [JsonPropertyName("Size")]
        public long? Size { get; set; }

        /// <summary>
        /// 备份的源类型(文件夹/文件)
        /// </summary>
        [JsonPropertyName("BackupTaskType")]
        public EnumExtensions.BackupTaskType BackupTaskType { get; set; }
    }
}
