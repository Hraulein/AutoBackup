using AutoBackup.Extensions;
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
using static AutoBackup.POJO.BackupItem;
using AutoBackup.Utils;

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
            ElevatedDragDropManager.Instance.EnableDragDrop(BackupList.Handle);
            ElevatedDragDropManager.Instance.ElevatedDragDrop += BackupList_DragDrop;
        }

        private void BackupList_DragDrop(object sender, ElevatedDragDropArgs e)
        {
            if (e.HWnd == BackupList.Handle)
            {

            }
        }

        /// <summary>
        /// 转换备份列表文件内容到listview (个性化显示数据到用户界面)
        /// </summary>
        /// <param name="backupItem"></param>
        private ListViewItem ConvertBackupItemsToListViewItem(POJO.BackupItem backupItem)
        {
            /* 添加图标到ImageList */
            imageList1.Images.Add("@Folder", SystemIcon.GetDirectoryIcon(false));
            imageList1.Images.Add(backupItem.BackupSourcePath, SystemIcon.GetIcon(backupItem.BackupSourcePath, false));
            /* 判断是否为文件 */
            var isFileOrFolder = backupItem.BackupTaskType == BackupTaskTypeEnum.File;
            /* 判断原有项目的路径是否存在 */
            var itemState = isFileOrFolder ? File.Exists(backupItem.BackupSourcePath) : Directory.Exists(backupItem.BackupSourcePath);
            var listItem = new ListViewItem
            {
                Tag = backupItem,
                Text = isFileOrFolder ? SystemExtName.GetFileExtTypeName(backupItem.BackupSourcePath) : "文件夹",
                ImageKey = isFileOrFolder ? backupItem.BackupSourcePath : "@Folder"
            };

            listItem.SubItems.AddRange(new ListViewItem.ListViewSubItem[]
            {
                new ListViewItem.ListViewSubItem(listItem, itemState ? "√": "×"), // 备份的任务状态
                new ListViewItem.ListViewSubItem(listItem, backupItem.BackupSourcePath), // 备份的源路径
                new ListViewItem.ListViewSubItem(listItem, itemState ? FileUtils.GetSizeString(Convert.ToInt64(backupItem.Size)) : isFileOrFolder ? "文件不存在" : "文件夹不存在"),
                new ListViewItem.ListViewSubItem(listItem, backupItem.LastBackupTime?.ToString() ?? "从未备份"), // 上次备份时间
                //new ListViewItem.ListViewSubItem(listItem, backupItem.BackupSettings?.Path ?? Local.Config.ConfigInstance.GlobalBackupSettings.Path), // 备份路径的单独设置(默认全局)
                new ListViewItem.ListViewSubItem(listItem, string.IsNullOrEmpty(backupItem.BackupSettings.Path) ? "跟随设置" : backupItem.BackupSettings.Path),
                new ListViewItem.ListViewSubItem(listItem, "Undefined") // 是否压缩备份
            });
            listItem.BackColor = itemState ? Color.FromArgb(255, 255, 255) : Color.FromArgb(255, 192, 192);
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
                int count = openFileDialog1.FileNames.Length;
                for (int i = 0; i < count; i++)
                {
                    POJO.BackupItem fileItem = new POJO.BackupItem
                    {
                        BackupTaskType = BackupTaskTypeEnum.File,  // 类型
                        BackupSourcePath = openFileDialog1.FileNames[i], // 路径
                        Size = Public.GetFileLength(openFileDialog1.FileNames[i]), // 大小
                        LastBackupTime = null, // 上次备份时间
                        BackupSettings = null // 备份设置
                    };
                    Local.Config.ConfigInstance.BackupItemsList.Add(fileItem);
                    BackupList.Items.Add(ConvertBackupItemsToListViewItem(fileItem));
                }
                Local.Config.SaveConfig();
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
                    BackupTaskType = BackupTaskTypeEnum.Folder,
                    BackupSourcePath = folderBrowserDialog1.SelectedPath,
                    Size = Public.GetFolderLength(folderBrowserDialog1.SelectedPath),
                    LastBackupTime = null,
                    BackupSettings = null
                };
                Local.Config.ConfigInstance.BackupItemsList.Add(folderItem);
                BackupList.Items.Add(ConvertBackupItemsToListViewItem(folderItem));
                Local.Config.SaveConfig();
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
            BtnDelRows_Click(sender, e);
        }
        /// <summary>
        /// 属性
        /// </summary>
        private void AttributeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        /// <summary>
        /// 右键菜单的一些限制
        /// </summary>
        private void CmsMouseRightList_Opened(object sender, EventArgs e)
        {
            DelRowsToolStripMenuItem.Visible = AttributeToolStripMenuItem.Visible = BackupList.SelectedItems.Count != 0;
        }

        private void BtnDelRows_Click(object sender, EventArgs e)
        {

        }
    }
}
