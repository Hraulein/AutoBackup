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
using System.Diagnostics;

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
            imageList1.Images.Add("@Folder?", SystemIcon.GetDirectoryIcon(false));
            foreach (var item in Local.Config.ConfigInstance.BackupItemsList)
            {
                BackupList.Items.Add(ConvertBackupItemsToListViewItem(item));
            }
            ElevatedDragDropManager.Instance.EnableDragDrop(BackupList.Handle);
            ElevatedDragDropManager.Instance.ElevatedDragDrop += BackupList_DragDrop;
            CheckBackupPath();
        }

        /// <summary>
        /// 拖拽添加
        /// </summary>
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
            bool itemState;
            string sizeString;
            ListViewItem listItem = new ListViewItem
            {
                Tag = backupItem,
            };
            if (backupItem.BackupTaskType == BackupTaskTypeEnum.File)
            {
                FileInfo fileInfo = new FileInfo(backupItem.BackupSourcePath);
                itemState = fileInfo.Exists && backupItem.GetBackupPath().Exists && !backupItem.CheckContainException();
                var ext = fileInfo.Extension;
                listItem.Text = SystemExtName.GetFileExtTypeName(ext);
                if (!imageList1.Images.ContainsKey(ext))
                {
                    imageList1.Images.Add(ext, SystemIcon.GetIcon(ext, false));
                    Debug.WriteLine("添加图标键:" + ext);
                }
                listItem.ImageKey = ext;
                sizeString = fileInfo.Exists ? FileUtils.GetSizeString(Convert.ToInt64(backupItem.Size)) : "文件不存在";
            }
            else
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(backupItem.BackupSourcePath);
                itemState = directoryInfo.Exists && backupItem.GetBackupPath().Exists && !backupItem.CheckContainException();
                if (directoryInfo.FullName == directoryInfo.Root.FullName)
                {
                    if (!imageList1.Images.ContainsKey($"@Drive[{directoryInfo.Root.FullName}]?"))
                    {
                        imageList1.Images.Add($"@Drive[{directoryInfo.Root.FullName}]?", SystemIcon.GetDriverIcon(directoryInfo.Root.FullName, false));
                    }
                    listItem.ImageKey = $"@Drive[{directoryInfo.Root.FullName}]?";
                    listItem.Text = "磁盘";
                    sizeString = directoryInfo.Exists ? FileUtils.GetSizeString(Convert.ToInt64(backupItem.Size)) : "磁盘不存在";
                }
                else
                {
                    listItem.ImageKey = "@Folder?";
                    listItem.Text = "文件夹";
                    sizeString = directoryInfo.Exists ? FileUtils.GetSizeString(Convert.ToInt64(backupItem.Size)) : "文件夹不存在";
                }
            }
            listItem.SubItems.AddRange(new ListViewItem.ListViewSubItem[]
            {
                new ListViewItem.ListViewSubItem(listItem, itemState ? "√": "×"), // 备份的任务状态
                new ListViewItem.ListViewSubItem(listItem, backupItem.BackupSourcePath), // 备份的源路径
                new ListViewItem.ListViewSubItem(listItem, sizeString),
                new ListViewItem.ListViewSubItem(listItem, backupItem.LastBackupTime?.ToString() ?? "从未备份"), // 上次备份时间
                new ListViewItem.ListViewSubItem(listItem, backupItem.GetBackupPathString()),
                new ListViewItem.ListViewSubItem(listItem, "不压缩") // 是否压缩备份
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
                Debug.WriteLine("添加文件" + Local.Config.SaveConfig());
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
                    Size = null,
                    LastBackupTime = null,
                    BackupSettings = null
                };
                Local.Config.ConfigInstance.BackupItemsList.Add(folderItem);
                var item = ConvertBackupItemsToListViewItem(folderItem);
                item.FlushFolderSize();
                BackupList.Items.Add(item);
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

        UI.ItemAttributeForm itemAttribute;

        /// <summary>
        /// 项目属性
        /// </summary>
        private void AttributeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (itemAttribute == null || itemAttribute.IsDisposed)
            {
                itemAttribute = new UI.ItemAttributeForm();
                itemAttribute.Show(this);
            }
            else
                itemAttribute.Activate();
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

        private void BtnCheckState_Click(object sender, EventArgs e)
        {
            BackupList.Items.Clear();
            foreach (var item in Local.Config.ConfigInstance.BackupItemsList)
            {
                BackupList.Items.Add(ConvertBackupItemsToListViewItem(item));
            }
        }
        /// <summary>
        /// 检查是否设置了备份路径
        /// </summary>
        private void CheckBackupPath()
        {
            string.IsNullOrEmpty(Local.Config.ConfigInstance.GlobalBackupSettings.Path);
        }
    }
}
