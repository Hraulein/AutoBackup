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
        /// <summary>
        /// 创建文件夹
        /// </summary>
        /// <param name="path">文件夹路径</param>
        private static string CreateDirectoryIfNotExists(string path)
        {
            var directory = new DirectoryInfo(path);
            if (!directory.Exists)
            {
                directory.Create();
            }
            return path;
        }

        /// <summary>
        /// 创建文件
        /// </summary>
        /// <param name="path">文件路径</param>
        private static string CreateFileIfNotExists(string path)
        {
            var file = new FileInfo(path);
            if (!file.Exists)
            {
                file.Create();
            }
            return path;
        }

        /// <summary>
        /// 程序数据根目录文件夹
        /// </summary>
        private readonly static string AutoBackupRootDirPath = new Func<string>(() =>
        {
            return CreateDirectoryIfNotExists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\SK-Studio\AutoBackup");
        })();

        /// <summary>
        /// 程序配置文件根目录文件夹
        /// </summary>
        private readonly static string ConfigFileRootPath = new Func<string>(() =>
        {
            return CreateDirectoryIfNotExists(AutoBackupRootDirPath + @"\Config");
        })();

        /// <summary>
        /// 程序日志文件根目录文件夹
        /// </summary>
        private readonly static string LogFileRootPath = new Func<string>(() =>
        {
            return CreateDirectoryIfNotExists(AutoBackupRootDirPath + @"\Log");
        })();

        /// <summary>
        /// 程序配置文件路径
        /// </summary>
        public readonly static string SystemConfigFilePath = new Func<string>(() =>
        {
            return CreateFileIfNotExists(ConfigFileRootPath + @"\config.json");
        })();

        /// <summary>
        /// 程序日志文件路径
        /// </summary>
        public static string LogFilePath = new Func<string>(() =>
        {
            return CreateFileIfNotExists(LogFileRootPath + $"\\{DateTime.Now.ToString("yyyy-MM-dd")}.log");
        })();
    }
    static class Config
    {

        /// <summary>
        /// 配置的实体类
        /// </summary>
        public static POJO.Config ConfigInstance { get; private set; } = new Func<POJO.Config>(() =>
          {
              try
              {
                  POJO.Config.Load(File.ReadAllText(FilePath.SystemConfigFilePath));
              }
              catch (JsonException e)
              {
                  Debug.WriteLine(e.ToString());
                  POJO.Config.Load("{}");
              }
              return POJO.Config.Instance;
          })();

        /// <summary>
        /// 保存配置到文件
        /// </summary>
        public static bool SaveConfig()
        {
            using (var streamWriter = new StreamWriter(FilePath.SystemConfigFilePath, false, Encoding.UTF8))
            {
                streamWriter.Write(ConfigInstance.ToString());
            }
            return true;
        }

        /// <summary>
        /// 重新加载配置
        /// </summary>
        public static bool ReloadConfig()
        {
            var result = POJO.Config.Load(File.ReadAllText(FilePath.SystemConfigFilePath));
            ConfigInstance = POJO.Config.Instance;
            return result;
        }

        /// <summary>
        /// 检查配置是否有问题
        /// </summary>
        /// <returns>无问题为true</returns>
        public static bool CheckBackupGlobalSettings()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(ConfigInstance.GlobalBackupSettings.Path);
            if (!directoryInfo.Exists)
            {
                return false;
            }
            if (directoryInfo.Attributes == FileAttributes.System || directoryInfo.Attributes == FileAttributes.ReadOnly)
            {
                return false;
            }
            return true;
        }
    }
}
