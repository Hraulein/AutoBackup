using System;
using System.ComponentModel;
using static AutoBackup.Model.SettingForm;

namespace AutoBackup.Extensions
{
    public static class EnumExtensions
    {
        public static string ToDescriptionString(this Enum val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }


        public static int GetMinutes(this BackupTimeUnitEnum BackupTimeUnit, int number)
        {
            return (int)BackupTimeUnit * number;
        }
    }
}
