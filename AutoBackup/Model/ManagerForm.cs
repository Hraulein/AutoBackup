using AutoBackup.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBackup
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 进入设置
        /// </summary>
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Model.SettingForm setting = new Model.SettingForm();
            setting.ShowDialog();
        }
        /// <summary>
        /// 窗体启动
        /// </summary>
        private void ManagerForm_Load(object sender, EventArgs e)
        {
            /*foreach(var item in Local.Config.ConfigInstance.BackupItemsList)
            {
                backupList.Items.Add(ConvertBackupItemsToListViewItem(item));
            }*/
        }
        /// <summary>
        /// 转换备份列表文件内容到listview
        /// </summary>
        /// <param name="backupItem"></param>
        /// <returns></returns>
        private ListViewItem ConvertBackupItemsToListViewItem(POJO.BackupItem backupItem)
        {
            var listItem = new ListViewItem
            {
                Tag = backupItem
            };
            listItem.SubItems.AddRange(new ListViewItem.ListViewSubItem[]
            {
                    new ListViewItem.ListViewSubItem(listItem,backupItem.BackupTaskType.ToDescriptionString()),
                    new ListViewItem.ListViewSubItem(listItem,"√"),
                    new ListViewItem.ListViewSubItem(listItem,backupItem.BackupSourcePath),
                    new ListViewItem.ListViewSubItem(listItem,backupItem.Size?.ToString()??"0"),
                    new ListViewItem.ListViewSubItem(listItem,backupItem.LastBackupTime?.ToString() ?? ""),
                    new ListViewItem.ListViewSubItem(listItem,backupItem.BackupSettings?.Path??Local.Config.ConfigInstance.GlobalBackupSettings.Path),
                    new ListViewItem.ListViewSubItem(listItem,"是")
            });
            return listItem;
        }
    }
}
