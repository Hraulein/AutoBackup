using System;
using AutoBackup.Extensions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace AutoBackup.POJO
{
    public class SKTimeWarp
    {
        /// <summary>
        /// 时间
        /// </summary>
        public int Time { get; set; }

        /// <summary>
        /// 具体单位
        /// </summary>
        public TimeUnitEnum Unit { get; set; }

        /// <summary>
        /// 时间单位枚举
        /// </summary>
        public enum TimeUnitEnum
        {
            [Description("分钟")]
            Minute = 1,
            [Description("小时")]
            Hour = 60,
            [Description("天")]
            Day = 1440,
        }
        public override string ToString()
        {
            return $"{Time.ToString()}{Unit.ToDescriptionString()}";
        }
    }
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

        public enum BackupCompression
        {
            [Description("不压缩")]
            NotCompressed = 0,
            [Description("普通压缩")]
            Normal = 1,
            [Description("高比压缩")]
            HighRatioCompression = 2,
        }

        public BackupSettings()
        {
            Path = "";
            Enable = true;
            BackupTime = null;
            ExpiredTime = null;
            Compression = BackupCompression.NotCompressed;
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
        public SKTimeWarp BackupTime { get; set; }

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
        public SKTimeWarp ExpiredTime { get; set; }

        /// <summary>
        /// 备份的压缩设置
        /// </summary>
        [JsonPropertyName("BackupCompression")]
        public BackupCompression Compression { get; set; }

    }
    public class Config
    {

        public Config()
        {
            GlobalBackupSettings = new BackupSettings
            {
                BackupTime = new SKTimeWarp()
                {
                    Time = 1,
                    Unit = SKTimeWarp.TimeUnitEnum.Day
                },
                Enable = true,
                BackupType = BackupSettings.BackupTypeEnum.FullVolume,
                ExpiredTime = null,
                Path = "",
            };
            BackupItemsList = new List<BackupItem>();
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions
            {
                WriteIndented = true
            });
        }

        public static Config Default { get; } = new Config();

        public static Config Instance { get; private set; } = null;

        public static bool Load(string json)
        {
            var config = JsonSerializer.Deserialize<Config>(json, new JsonSerializerOptions
            {
                IgnoreNullValues = true,
                IgnoreReadOnlyProperties = true,
                AllowTrailingCommas = true,
                PropertyNameCaseInsensitive = true
            });
            if (config == null)
            {
                return false;
            }
            Instance = config;
            return true;
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

