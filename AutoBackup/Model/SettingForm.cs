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
            ReadGlobalBackupSettings();
            Console.WriteLine("备份设置:" + Local.Config.ConfigInstance.GlobalBackupSettings.Enable);
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
                TxtShowRootDir.Text = folderBrowserDialog1.SelectedPath;
        }
        /// <summary>
        /// 窗体关闭前
        /// </summary>
        private void SettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveBackupConfig();
        }

        private bool SaveBackupConfig()
        {
            Local.Config.ConfigInstance.GlobalBackupSettings.Path = TxtShowRootDir.Text;
            Local.Config.ConfigInstance.GlobalBackupSettings.Enable = ChkAutoBackup.Checked;
            Local.Config.ConfigInstance.GlobalBackupSettings.BackupTime = CmbABTime.SelectedIndex;
            if (ChkAllBackup.Checked)
                Local.Config.ConfigInstance.GlobalBackupSettings.BackupType = POJO.EnumExtensions.BackupType.FullVolume;
            if (ChkIncBackup.Checked)
                Local.Config.ConfigInstance.GlobalBackupSettings.BackupType = POJO.EnumExtensions.BackupType.Increment;
            if (ChkAllBackup.Checked && ChkIncBackup.Checked)
                Local.Config.ConfigInstance.GlobalBackupSettings.BackupType = POJO.EnumExtensions.BackupType.AllType;
            if (ChkAutoDelete.Checked)
            {
                // Local.Config.ConfigInstance.GlobalBackupSettings.ExpiredTime = ;
            }
            return Local.Config.SaveConfig();
        }
        /// <summary>
        /// 读取全局设置并显示在界面
        /// </summary>
        private void ReadGlobalBackupSettings()
        {
            /* 备份保存目录 */
            TxtShowRootDir.Text = Local.Config.ConfigInstance.GlobalBackupSettings.Path;
            /* 自动备份设置 */
            if (Local.Config.ConfigInstance.GlobalBackupSettings.Enable)
            {
                ChkAutoBackup.Checked = true;
                int? backuptime = Local.Config.ConfigInstance.GlobalBackupSettings.BackupTime;
                CmbABTime.SelectedIndex = (backuptime != null) ? Convert.ToInt16(backuptime) : -1;
                switch (Local.Config.ConfigInstance.GlobalBackupSettings.BackupType)
                {
                    case POJO.EnumExtensions.BackupType.FullVolume:
                        ChkAllBackup.Checked = true; break;
                    case POJO.EnumExtensions.BackupType.Increment:
                        ChkIncBackup.Checked = true; break;
                    case POJO.EnumExtensions.BackupType.AllType:
                        ChkAllBackup.Checked = true;
                        ChkIncBackup.Checked = true;
                        break;
                }
            }
            else
            {
                ChkAutoBackup.Checked = false;
                CmbABTime.SelectedIndex = -1;
                ChkAllBackup.Checked = false;
                ChkIncBackup.Checked = false;
            }
            /* 备份有效期 */
            if (Local.Config.ConfigInstance.GlobalBackupSettings.ExpiredTime == null)
                ChkAutoDelete.Checked = false;
            else
            {

            }
        }
    }
}
