using System;
using AutoBackup.Extensions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Serialization;
using static AutoBackup.Model.SettingForm;

namespace AutoBackup.POJO
{
    public class BackupSettings
    {
        public enum BackupTypeEnum
        {
            /// <summary>
            /// 全量备份
            /// </summary>
            [Description("全量")]
            FullVolume = 0,
            /// <summary>
            /// 增量备份
            /// </summary>
            [Description("增量")]
            Increment = 1,
        }
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
        /// 备份类型(全量/增量)
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        [JsonPropertyName("BackupType")]
        public BackupTypeEnum BackupType { get; set; }

        /// <summary>
        /// 过期时间, 无限制请使用null
        /// </summary>
        [JsonPropertyName("ExpiredTime")]
        public int? ExpiredTime { get; set; }

    }
    public class Config
    {
        
        public Config()
        {
            GlobalBackupSettings = new BackupSettings
            {
                BackupTime = BackupTimeUnitEnum.Day.GetMinutes(1),
                Enable = true,
                BackupType = BackupSettings.BackupTypeEnum.FullVolume,
                ExpiredTime = null,
                Path = "",
            };
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

