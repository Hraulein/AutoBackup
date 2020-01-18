using System;
using System.ComponentModel;
using static AutoBackup.POJO.SKTimeWarp;

namespace AutoBackup.Extensions
{
    public static class EnumExtensions
    {
        public static string ToDescriptionString(this Enum val)
        {
            if (val == null)
            {
                const string ParamName = "枚举实例不能为null";
                throw new ArgumentNullException(paramName: ParamName);
            }
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }


        public static int GetMinutes(this TimeUnitEnum BackupTimeUnit, int number)
        {
            return (int)BackupTimeUnit * number;
        }
    }
}
