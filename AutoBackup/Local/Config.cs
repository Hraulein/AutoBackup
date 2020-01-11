using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace AutoBackup.Local
{
    static class FilePath
    {
        /* 创建文件夹 */
        private static string CreateDirectoryIfNotExists(string path)
        {
            var directory = new DirectoryInfo(path);
            if (!directory.Exists)
            {
                directory.Create();
            }
            return path;
        }

        /* 创建文件 */
        private static string CreateFileIfNotExists(string path)
        {
            var file = new FileInfo(path);
            if (!file.Exists)
            {
                file.Create();
            }
            return path;
        }

        /* 程序数据根目录文件夹 */
        private readonly static string AutoBackupRootDirPath = new Func<string>(() =>
        {
            return CreateDirectoryIfNotExists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\SK-Studio\AutoBackup");
        })();

        /* 程序配置文件根目录文件夹 */
        private readonly static string ConfigFileRootPath = new Func<string>(() =>
        {
            return CreateDirectoryIfNotExists(AutoBackupRootDirPath + @"\Config");
        })();

        /* 程序日志文件根目录文件夹 */
        private readonly static string LogFileRootPath = new Func<string>(() =>
        {
            return CreateDirectoryIfNotExists(AutoBackupRootDirPath + @"\Log");
        })();

        /* 程序配置文件路径 */
        public readonly static string SystemConfigFilePath = new Func<string>(() =>
        {
            return CreateFileIfNotExists(ConfigFileRootPath + @"\config.json");
        })();

        /* 程序日志文件路径 */
        public static string LogFilePath = new Func<string>(() =>
        {
            return CreateFileIfNotExists(LogFileRootPath + $"\\{DateTime.Now.ToString("yyyy-MM-dd")}.log");
        })();
    }
    static class Config
    {
        /* 配置的实体类 */
        public readonly static POJO.Config ConfigInstance = new Func<POJO.Config>(() =>
        {
            try
            {
                var config = JsonSerializer.Deserialize<POJO.Config>(File.ReadAllText(FilePath.SystemConfigFilePath));
                if (config == null)
                {
                    config = new POJO.Config();
                }
                return config;
            }
            catch (JsonException e)
            {
                Debug.WriteLine(e.ToString());
                return new POJO.Config();
            }
        })();

        /* 保存配置到文件 */
        public static void SaveConfig()
        {
            using (var streamWriter = new StreamWriter(FilePath.SystemConfigFilePath, false, Encoding.UTF8))
            {
                streamWriter.Write(JsonSerializer.Serialize(ConfigInstance, new JsonSerializerOptions
                {
                    WriteIndented = true
                }));
            }
        }

    }
}
