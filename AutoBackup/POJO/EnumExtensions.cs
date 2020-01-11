using System.ComponentModel;

namespace AutoBackup.POJO
{
    public static class EnumExtensions
    {
        public enum BackupType
        {
            /// <summary>
            /// 全量备份
            /// </summary>
            [Description("全量")]
            FullVolume,
            /// <summary>
            /// 增量备份
            /// </summary>
            [Description("增量")]
            Increment,
            /// <summary>
            /// 我全都要
            /// </summary>
            [Description("两者都要")]
            AllType
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
