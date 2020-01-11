using System.ComponentModel;

namespace AutoBackup.POJO
{
    public static class EnumExtensions
    {
        public enum BackupType
        {
            [Description("全量")]
            FullVolume,
            [Description("增量")]
            Increment
        }
        public enum BackupTaskType
        {
            [Description("文件夹")]
            Folder,
            [Description("文件")]
            File
        }
        public static string ToDescriptionString(this BackupType val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
        public static string ToDescriptionString(this BackupTaskType val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}
