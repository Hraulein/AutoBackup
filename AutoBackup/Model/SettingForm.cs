using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoBackup.Model
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体启动
        /// </summary>
        private void SettingForm_Load(object sender, EventArgs e)
        {
            TxtShowRootDir.Text = Local.Config.ConfigInstance.GlobalBackupSettings.Path;
        }
        /// <summary>
        /// 当"启用自动备份"的check属性更改时
        /// </summary>
        private void ChkAutoBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAutoBackup.Checked)
                PnlABSettings.Visible = true;
            else
                PnlABSettings.Visible = false;
        }
        /// <summary>
        /// 当"启动自动删除"的check属性更改时
        /// </summary>
        private void ChkAutoDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAutoDelete.Checked)
                PnlADSettings.Visible = true;
            else
                PnlADSettings.Visible = false;
        }
        /// <summary>
        /// 选择备份的保存目录
        /// </summary>
        private void BtnOptRootDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Local.Config.ConfigInstance.GlobalBackupSettings.Path = folderBrowserDialog1.SelectedPath;
                TxtShowRootDir.Text = Local.Config.ConfigInstance.GlobalBackupSettings.Path;
            }
        }
        /// <summary>
        /// 设置窗体关闭前保存设置
        /// </summary>
        private void SettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Local.Config.SaveConfig();
        }
    }
}
