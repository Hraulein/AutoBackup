using AutoBackup.POJO;
using AutoBackup.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBackup.Extensions
{
    public static partial class CloneExtensions
    {
        public static List<T> Clone<T>(this IList<T> listToClone) where T : ICloneable
        {
            return listToClone.Select(item => (T)item.Clone()).ToList();
        }
    }
    public static partial class ListViewItemExtensions
    {
        public static BackupItem GetBackupItem(this ListViewItem listViewItem)
        {
            return listViewItem?.Tag as BackupItem;
        }

        public static void BindBackupItem(this ListViewItem listViewItem, BackupItem backupItem)
        {
            if (listViewItem == null)
            {
                return;
            }
            listViewItem.Tag = backupItem;
        }

        public static async Task FlushFolderSize(this ListViewItem listViewItem)
        {
            if (listViewItem == null)
            {
                return;
            }
            listViewItem.SubItems[3].Text = "正在统计";
            var length = await Public.GetFolderLength(new DirectoryInfo(listViewItem.GetBackupItem().BackupSourcePath));
            if (length < 0)
            {
                listViewItem.GetBackupItem().Size = null;
            }
            else
            {
                listViewItem.GetBackupItem().Size = length;
                listViewItem.SubItems[3].Text = FileUtils.GetSizeString(length);
            }
            Local.Config.SaveConfig();
        }
    }
}
