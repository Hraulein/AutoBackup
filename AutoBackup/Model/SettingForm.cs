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
        /// 备份的设置(读取及修改)
        /// </summary>
        POJO.Config.BackupSettings settings = new POJO.Config.BackupSettings();


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
                settings.Path = folderBrowserDialog1.SelectedPath + @"\AutoBackup";
                TxtShowRootDir.Text = settings.Path;
            }
        }
        /// <summary>
        /// 设置窗体关闭前保存设置
        /// </summary>
        private void SettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            settings.Path = TxtShowRootDir.Text;
            if (ChkAutoBackup.Checked)
            {
                if (CmbABTime.SelectedIndex == -1)
                {
                    MessageBox.Show("你勾选了自动备份, 请选择备份间隔");
                    CmbABTime.Focus();
                    e.Cancel = true;
                }
                else if (!ChkAllBackup.Checked && !ChkIncBackup.Checked)
                {
                    MessageBox.Show("你勾选了自动备份, 请至少选择一种备份类型");
                    ChkAllBackup.Focus();
                    e.Cancel = true;
                }
                else
                {
                    settings.Enable = true;
                    if (ChkAllBackup.Checked)
                        settings.BackupType = POJO.EnumExtensions.BackupType.FullVolume;
                    if (ChkIncBackup.Checked)
                        settings.BackupType = POJO.EnumExtensions.BackupType.Increment;
                    if (ChkAllBackup.Checked && ChkIncBackup.Checked)
                        settings.BackupType = POJO.EnumExtensions.BackupType.AllType;
                    Local.Config.SaveConfig();
                    e.Cancel = false;
                }
            }
            else
            {
                settings.Enable = false;
                Local.Config.SaveConfig();
            }
        }
    }
}
