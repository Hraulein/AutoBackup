using System;
using AutoBackup.Extensions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Windows.Forms;

namespace AutoBackup.POJO
{
    public class SKTimeWarp
    {
        /// <summary>
        /// 启用
        /// </summary>
        [JsonPropertyName("Enable")]
        public bool Enable { get; set; } = false;

        /// <summary>
        /// 时间
        /// </summary>
        public int Time { get; set; } = 1;

        /// <summary>
        /// 具体单位
        /// </summary>
        public TimeUnitEnum Unit { get; set; } = TimeUnitEnum.Day;

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
            BackupTime = new SKTimeWarp();
            ExpiredTime = new SKTimeWarp();
            Compression = BackupCompression.NotCompressed;
        }

        /// <summary>
        /// 备份路径
        /// </summary>
        [JsonPropertyName("Path")]
        public string Path { get; set; }


        /// <summary>
        /// 自动备份的周期未设置请将Enable置为false
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
        /// 过期时间, 无限制请将Enable置为false
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
                    Enable = true,
                },
                BackupType = BackupSettings.BackupTypeEnum.FullVolume,
                ExpiredTime = new SKTimeWarp(),
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

