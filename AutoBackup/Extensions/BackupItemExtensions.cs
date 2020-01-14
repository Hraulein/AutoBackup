using AutoBackup.POJO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBackup.Extensions
{
    public static class BackupItemExtensions
    {
        public static bool CheckContainException(this BackupItem backupItem)
        {
            if (backupItem == null)
            {
                return false;
            }
            DirectoryInfo directoryInfo = new DirectoryInfo(backupItem.BackupSourcePath);
            DirectoryInfo backupDirectInfo = backupItem.GetBackupPath();
            return backupDirectInfo.FullName.StartsWith(directoryInfo.FullName);
        }
        public static string GetBackupPathString(this BackupItem backupItem)
        {
            if (backupItem == null)
            {
                return null;
            }
            return string.IsNullOrEmpty(backupItem.BackupSettings.Path) ? $"[全局]{Local.Config.ConfigInstance.GlobalBackupSettings.Path}" : backupItem.BackupSettings.Path;
        }
        public static DirectoryInfo GetBackupPath(this BackupItem backupItem)
        {
            if (backupItem == null)
            {
                return null;
            }
            return string.IsNullOrEmpty(backupItem.BackupSettings.Path) ? new DirectoryInfo(Local.Config.ConfigInstance.GlobalBackupSettings.Path) : new DirectoryInfo(backupItem.BackupSettings.Path);
        }
    }
}
