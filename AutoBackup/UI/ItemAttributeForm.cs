using AutoBackup.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBackup.UI
{
    public partial class ItemAttributeForm : Form
    {
        public ItemAttributeForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.FromArgb(217, 217, 217)), 0, 0, 0, panel1.Height);  //左  
            e.Graphics.DrawLine(new Pen(Color.FromArgb(217, 217, 217)), 0, 0, panel1.Width, 0);   //上  
            e.Graphics.DrawLine(new Pen(Color.FromArgb(217, 217, 217)), 0, panel1.Height - 1, panel1.Width, panel1.Height - 1); //下  
            e.Graphics.DrawLine(new Pen(Color.FromArgb(217, 217, 217)), panel1.Width - 1, 0, panel1.Width - 1, panel1.Height);  //右 
        }
        /// <summary>
        /// 更改备份的保存路径(单独)
        /// </summary>
        private void BtnCheckPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                TxtBackupSavePath.Text = folderBrowser.SelectedPath;
            }
        }
        /// <summary>
        /// 窗体启动
        /// </summary>
        private void ItemAttributeForm_Load(object sender, EventArgs e)
        {
            CmbCompressionType.DataSource = Enum.GetNames(typeof(POJO.BackupSettings.BackupCompression)).Select(item => ((POJO.BackupSettings.BackupCompression)Enum.Parse(typeof(POJO.BackupSettings.BackupCompression), item)).ToDescriptionString()).ToList();
        }
    }
}
