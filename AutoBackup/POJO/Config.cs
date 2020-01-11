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
                Enable = true;
                Path = "";
                ExpiredTime = null;
            }

            /* 备份路径 */
            [JsonPropertyName("Path")]
            public string Path { get; set; }

            /* 启用备份 */
            [JsonPropertyName("Enable")]
            public bool Enable { get; set; }

            /* 备份类型(全量/增量) */
            [JsonConverter(typeof(JsonStringEnumConverter))]
            [JsonPropertyName("BackupType")]
            public EnumExtensions.BackupType BackupType { get; set; }

            /* 过期时间,无限制请使用null */
            [JsonPropertyName("ExpiredTime")]
            public DateTime? ExpiredTime { get; set; }

        }


        public Config()
        {
            GlobalBackupSettings = new BackupSettings();
            BackupItemsList = new List<BackupItem>();
        }

        /* 全局备份设置 */
        [JsonPropertyName("GlobalSettingsBackup")]
        public BackupSettings GlobalBackupSettings { get; set; }

        /* 备份任务列表 */
        [JsonPropertyName("BackupList")]
        public List<BackupItem> BackupItemsList { get; set; }
    }
}

