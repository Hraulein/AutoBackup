using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AutoBackup.POJO
{
    class Config
    {
        public class BackupSettings
        {
            public BackupSettings()
            {
                Path = "";
                Enable = true;
                BackupTime = null;
                ExpiredTime = null;
            }

            /// <summary>
            /// 备份路径
            /// </summary>
            [JsonPropertyName("Path")]
            public string Path { get; set; }

            /// <summary>
            /// 启用自动备份
            /// </summary>
            [JsonPropertyName("Enable")]
            public bool Enable { get; set; }

            /// <summary>
            /// 自动备份的周期(未设置请使用null)
            /// </summary>
            [JsonPropertyName("BackupTime")]
            public int? BackupTime { get; set; }

            /// <summary>
            /// 备份类型(全量/增量/我全都要)
            /// </summary>
            [JsonConverter(typeof(JsonStringEnumConverter))]
            [JsonPropertyName("BackupType")]
            public EnumExtensions.BackupType BackupType { get; set; }

            /// <summary>
            /// 过期时间, 无限制请使用null
            /// </summary>
            [JsonPropertyName("ExpiredTime")]
            public DateTime? ExpiredTime { get; set; }

        }


        public Config()
        {
            GlobalBackupSettings = new BackupSettings();
            BackupItemsList = new List<BackupItem>();
        }

        /// <summary>
        /// 全局备份设置
        /// </summary>
        [JsonPropertyName("GlobalSettingsBackup")]
        public BackupSettings GlobalBackupSettings { get; set; }

        /// <summary>
        /// 备份任务列表
        /// </summary>
        [JsonPropertyName("BackupList")]
        public List<BackupItem> BackupItemsList { get; set; }
    }
}

