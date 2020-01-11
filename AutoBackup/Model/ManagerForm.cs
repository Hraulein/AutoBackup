using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            foreach (var item in Local.Config.ConfigInstance.BackupItemsList)
            {
                BackupList.Items.Add(ConvertBackupItemsToListViewItem(item));
            }
            Utils.ElevatedDragDropManager.Instance.EnableDragDrop(BackupList.Handle);
            Utils.ElevatedDragDropManager.Instance.ElevatedDragDrop += BackupList_DragDrop;
        }

        private void BackupList_DragDrop(object sender, Utils.ElevatedDragDropArgs e)
        {
            if (e.HWnd == BackupList.Handle)
            {

            }
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
                    new ListViewItem.ListViewSubItem(listItem,POJO.EnumExtensions.ToDescriptionString(backupItem.BackupTaskType)),
                    new ListViewItem.ListViewSubItem(listItem,"√"),
                    new ListViewItem.ListViewSubItem(listItem,backupItem.BackupSourcePath),
                    new ListViewItem.ListViewSubItem(listItem,backupItem.Size?.ToString()??"0"),
                    new ListViewItem.ListViewSubItem(listItem,backupItem.LastBackupTime?.ToString() ?? ""),
                    new ListViewItem.ListViewSubItem(listItem,backupItem.BackupSettings?.Path??Local.Config.ConfigInstance.GlobalBackupSettings.Path),
                    new ListViewItem.ListViewSubItem(listItem,"是")
            });
            return listItem;
        }

        private void BackupList_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void BackupList_DragLeave(object sender, EventArgs e)
        {

        }

        private void BackupList_DragOver(object sender, DragEventArgs e)
        {

        }

        private void BackupList_KeyDown(object sender, KeyEventArgs e)
        {

        }
        /// <summary>
        /// 添加文件
        /// </summary>
        private void BtnAddFiles_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "所有文件(*.*)|*.*"; openFileDialog1.Title = "选择要备份的文件";
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                POJO.BackupItem fileItem = new POJO.BackupItem
                {
                    BackupTaskType = POJO.EnumExtensions.BackupTaskType.File,
                    BackupSourcePath = openFileDialog1.FileName,
                    Size = Utils.Public.GetFileLength(openFileDialog1.FileName),
                    LastBackupTime = null,
                    BackupSettings = null
                };
                ConvertBackupItemsToListViewItem(fileItem);
                Local.Config.ConfigInstance.BackupItemsList.Add(fileItem);
            }
            else
            {
                MessageBox.Show("You cancel add file");
            }
        }
        /// <summary>
        /// 添加文件夹
        /// </summary>
        /// <param name="sender"></param>
        private void BtnAddFolders_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "选择要备份的文件夹";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                POJO.BackupItem folderItem = new POJO.BackupItem
                {
                    BackupTaskType = POJO.EnumExtensions.BackupTaskType.Folder,
                    BackupSourcePath = folderBrowserDialog1.SelectedPath,
                    Size = Utils.Public.GetFolderLength(folderBrowserDialog1.SelectedPath),
                    LastBackupTime = null,
                    BackupSettings = null
                };
                ConvertBackupItemsToListViewItem(folderItem);
                Local.Config.ConfigInstance.BackupItemsList.Add(folderItem);
            }
            else
            {
                MessageBox.Show("You cancel add folder");
            }
        }

        #region listview右键菜单

        /// <summary>
        /// 添加文件
        /// </summary>
        private void AddFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnAddFiles_Click(sender, e);
        }
        /// <summary>
        /// 添加文件夹
        /// </summary>
        private void AddFoldersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnAddFolders_Click(sender, e);
        }
        /// <summary>
        /// 删除项目
        /// </summary>
        private void DelRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 是否压缩
        /// </summary>
        private void ZipToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 属性
        /// </summary>
        private void AttributeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
