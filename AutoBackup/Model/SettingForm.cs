using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoBackup.Extensions;
using static AutoBackup.POJO.Config.BackupSettings;

namespace AutoBackup.Model
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private static class Resource
        {
            /// <summary>
            /// 获取BackupTimeUnitEnum的内容和值
            /// </summary>
            public static readonly Tuple<List<string>, List<BackupTimeUnitEnum>> BackupTimeUnitsTuple = new Func<Tuple<List<string>, List<BackupTimeUnitEnum>>>(() =>
            {
                var BackupTimeUnits = new List<string>();
                var SourceNameTag = new List<BackupTimeUnitEnum>();
                FieldInfo[] fields = typeof(BackupTimeUnitEnum).GetFields();
                foreach (var fieldInfo in fields)
                {
                    if (fieldInfo.Name.Equals("value__"))
                        continue;
                    var unit = (BackupTimeUnitEnum)Enum.Parse(typeof(BackupTimeUnitEnum), fieldInfo.Name);
                    BackupTimeUnits.Add(unit.ToDescriptionString());
                    SourceNameTag.Add(unit);
                }
                return Tuple.Create(BackupTimeUnits, SourceNameTag);
            })();

            /// <summary>
            /// 窗口是否初始化完毕
            /// </summary>
            public static bool InitFinished = false;
        }

        /// <summary>
        /// 备份/过期时间单位
        /// </summary>
        public enum BackupTimeUnitEnum
        {
            [Description("分钟")]
            Minute = 1,
            [Description("小时")]
            Hour = 60,
            [Description("天")]
            Day = 1440,
        }

        /// <summary>
        /// 窗体启动
        /// </summary>
        private void SettingForm_Load(object sender, EventArgs e)
        {
            Resource.InitFinished = false;

            /* 绑定数据源 */
            BackupCycleUnit.DataSource = Resource.BackupTimeUnitsTuple.Item1;
            BackupCycleUnit.Tag = Resource.BackupTimeUnitsTuple.Item2;
            BackupCycleUnit.SelectedIndex = 0;

            /* 绑定数据源 */
            BackupExpiredUnit.DataSource = Resource.BackupTimeUnitsTuple.Item1;
            BackupExpiredUnit.Tag = Resource.BackupTimeUnitsTuple.Item2;
            BackupExpiredUnit.SelectedIndex = 0;

            ReadGlobalBackupSettings();
            Console.WriteLine("备份设置:" + Local.Config.ConfigInstance.GlobalBackupSettings.Enable);
            Resource.InitFinished = true;
        }
        /// <summary>
        /// 当"启用自动备份"的check属性更改时
        /// </summary>
        private void ChkAutoBackup_CheckedChanged(object sender, EventArgs e)
        {
            PnlABSettings.Visible = ChkAutoBackup.Checked;
            if (!Resource.InitFinished)
            {
                return;
            }
            Local.Config.ConfigInstance.GlobalBackupSettings.Enable = ChkAutoBackup.Checked;
        }
        /// <summary>
        /// 当"启动自动删除"的check属性更改时
        /// </summary>
        private void ChkAutoDelete_CheckedChanged(object sender, EventArgs e)
        {
            PnlADSettings.Visible = ChkAutoDelete.Checked;
            if (!Resource.InitFinished)
            {
                return;
            }
            if (ChkAutoDelete.Checked)
            {
                Local.Config.ConfigInstance.GlobalBackupSettings.ExpiredTime = (BackupExpiredUnit.Tag as List<BackupTimeUnitEnum>)[BackupExpiredUnit.SelectedIndex].GetMinutes(Convert.ToInt32(BackupExpiredNumericUpDown.Value));
            }
            else
            {
                Local.Config.ConfigInstance.GlobalBackupSettings.ExpiredTime = null;
            }
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
            Debug.WriteLine(Local.Config.SaveConfig());
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
                /* 获取备份周期,如果为空则使用默认值Day.GetMinutes(1) */
                BackupCycleNumericUpDown.Value = Local.Config.ConfigInstance.GlobalBackupSettings.BackupTime ?? BackupTimeUnitEnum.Day.GetMinutes(1);
                _ = Local.Config.ConfigInstance.GlobalBackupSettings.BackupType == BackupTypeEnum.FullVolume ? FullRadioButton.Checked = true : IncRadioButton.Checked = true;
            }
            else
            {
                ChkAutoBackup.Checked = FullRadioButton.Checked = IncRadioButton.Checked = false;
                BackupCycleUnit.SelectedIndex = -1;
            }
            /* 备份有效期 */
            if (Local.Config.ConfigInstance.GlobalBackupSettings.ExpiredTime == null)
            {
                ChkAutoDelete.Checked = false;
            }
            else
            {
                ChkAutoDelete.Checked = true;
            }
        }

        private void BackupCycleNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!Resource.InitFinished)
            {
                return;
            }
            Local.Config.ConfigInstance.GlobalBackupSettings.BackupTime = (BackupCycleUnit.Tag as List<BackupTimeUnitEnum>)[BackupCycleUnit.SelectedIndex].GetMinutes(Convert.ToInt32(BackupCycleNumericUpDown.Value));
        }

        private void BackupExpiredNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!Resource.InitFinished)
            {
                return;
            }
            Local.Config.ConfigInstance.GlobalBackupSettings.ExpiredTime = (BackupExpiredUnit.Tag as List<BackupTimeUnitEnum>)[BackupExpiredUnit.SelectedIndex].GetMinutes(Convert.ToInt32(BackupExpiredNumericUpDown.Value));
        }

        private void BackupCycleUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Resource.InitFinished)
            {
                return;
            }
            Local.Config.ConfigInstance.GlobalBackupSettings.BackupTime = (BackupCycleUnit.Tag as List<BackupTimeUnitEnum>)[BackupCycleUnit.SelectedIndex].GetMinutes(Convert.ToInt32(BackupCycleNumericUpDown.Value));
        }

        private void BackupExpiredUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Resource.InitFinished)
            {
                return;
            }
            Local.Config.ConfigInstance.GlobalBackupSettings.ExpiredTime = (BackupExpiredUnit.Tag as List<BackupTimeUnitEnum>)[BackupExpiredUnit.SelectedIndex].GetMinutes(Convert.ToInt32(BackupExpiredNumericUpDown.Value));
        }

        private void TxtShowRootDir_TextChanged(object sender, EventArgs e)
        {
            if (!Resource.InitFinished)
            {
                return;
            }
            Local.Config.ConfigInstance.GlobalBackupSettings.Path = TxtShowRootDir.Text;
        }

        private void ChkAllBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (!Resource.InitFinished)
            {
                return;
            }
            Local.Config.ConfigInstance.GlobalBackupSettings.BackupType = BackupTypeEnum.FullVolume;
        }


        private void ChkIncBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (!Resource.InitFinished)
            {
                return;
            }
            Local.Config.ConfigInstance.GlobalBackupSettings.BackupType = BackupTypeEnum.Increment;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
