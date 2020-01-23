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
using AutoBackup.POJO;
using static AutoBackup.POJO.BackupSettings;
using static AutoBackup.POJO.SKTimeWarp;

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
            public static readonly Tuple<List<string>, List<TimeUnitEnum>> BackupTimeUnitsTuple = new Func<Tuple<List<string>, List<TimeUnitEnum>>>(() =>
            {
                var TimeUnits = new List<string>();
                var SourceNameTag = new List<TimeUnitEnum>();
                FieldInfo[] fields = typeof(TimeUnitEnum).GetFields();
                foreach (var fieldInfo in fields)
                {
                    if (fieldInfo.Name == "value__")
                        continue;
                    var unit = (TimeUnitEnum)Enum.Parse(typeof(TimeUnitEnum), fieldInfo.Name);
                    TimeUnits.Add(unit.ToDescriptionString());
                    SourceNameTag.Add(unit);
                }
                return Tuple.Create(TimeUnits, SourceNameTag);
            })();

            /// <summary>
            /// 窗口是否初始化完毕
            /// </summary>
            public static bool InitFinished = false;
        }
        /// <summary>
        /// 窗体启动
        /// </summary>
        private void SettingForm_Load(object sender, EventArgs e)
        {
            Resource.InitFinished = false;
            /* 绑定数据源 */
            BackupCycleUnit.DataSource = Resource.BackupTimeUnitsTuple.Item1.Clone();
            BackupCycleUnit.Tag = Resource.BackupTimeUnitsTuple.Item2;
            BackupCycleUnit.SelectedIndex = 0;
            /* 绑定数据源 */
            BackupExpiredUnit.DataSource = Resource.BackupTimeUnitsTuple.Item1.Clone();
            BackupExpiredUnit.Tag = Resource.BackupTimeUnitsTuple.Item2;
            BackupExpiredUnit.SelectedIndex = 0;
            ReadGlobalBackupSettings();
            Console.WriteLine("备份设置:" + Local.Config.ConfigInstance.GlobalBackupSettings.BackupTime.Enable);
            Resource.InitFinished = true;
            LimitNumericUpDownValue(BackupCycleUnit, BackupCycleNumericUpDown);
            LimitNumericUpDownValue(BackupExpiredUnit, BackupExpiredNumericUpDown);
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
            Local.Config.ConfigInstance.GlobalBackupSettings.BackupTime.Enable = ChkAutoBackup.Checked;
        }
        /// <summary>
        /// 当"备份的有效期"的check属性更改时
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
                Local.Config.ConfigInstance.GlobalBackupSettings.ExpiredTime.Enable = true;
                Local.Config.ConfigInstance.GlobalBackupSettings.ExpiredTime.Time = Convert.ToInt32(BackupExpiredNumericUpDown.Value);
                Local.Config.ConfigInstance.GlobalBackupSettings.ExpiredTime.Unit = (BackupExpiredUnit.Tag as List<TimeUnitEnum>)[BackupExpiredUnit.SelectedIndex];
            }
            else
            {
                Local.Config.ConfigInstance.GlobalBackupSettings.ExpiredTime.Enable = false;
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
            if (Local.Config.ConfigInstance.GlobalBackupSettings.BackupTime.Enable)
            {
                ChkAutoBackup.Checked = true;
                /* 获取备份周期,如果为空则使用默认值 */
                BackupCycleNumericUpDown.Value = Local.Config.ConfigInstance.GlobalBackupSettings.BackupTime?.Time ?? Config.Default.GlobalBackupSettings.BackupTime.Time;
                BackupCycleUnit.SelectedIndex = Resource.BackupTimeUnitsTuple.Item1.IndexOf(Local.Config.ConfigInstance.GlobalBackupSettings.BackupTime?.Unit.ToDescriptionString() ?? Config.Default.GlobalBackupSettings.BackupTime.Unit.ToDescriptionString());
                _ = Local.Config.ConfigInstance.GlobalBackupSettings.BackupType == BackupTypeEnum.FullVolume ? FullRadioButton.Checked = true : IncRadioButton.Checked = true;
            }
            else
            {
                ChkAutoBackup.Checked = FullRadioButton.Checked = IncRadioButton.Checked = false;
                BackupCycleUnit.SelectedIndex = -1;
            }
            /* 备份有效期 */
            if (Local.Config.ConfigInstance.GlobalBackupSettings.ExpiredTime.Enable)
            {
                ChkAutoDelete.Checked = true;
                BackupExpiredNumericUpDown.Value = Local.Config.ConfigInstance.GlobalBackupSettings.ExpiredTime?.Time ?? Config.Default.GlobalBackupSettings.ExpiredTime.Time;
                BackupExpiredUnit.SelectedIndex = Resource.BackupTimeUnitsTuple.Item1.IndexOf(Local.Config.ConfigInstance.GlobalBackupSettings.ExpiredTime?.Unit.ToDescriptionString() ?? Config.Default.GlobalBackupSettings.ExpiredTime.Unit.ToDescriptionString());
            }
            else
            {
                ChkAutoDelete.Checked = false;
            }
        }
        /// <summary>
        /// 根据combobox控件的不同选项限制numericupdown的min和max值
        /// </summary>
        private void LimitNumericUpDownValue(ComboBox comboBox, NumericUpDown numericUpDown)
        {
            switch (comboBox.SelectedItem.ToString())
            {
                case "分钟":
                    numericUpDown.Value = numericUpDown.Minimum = 60;
                    numericUpDown.Maximum = 1440 * 30;
                    break;
                case "小时":
                    numericUpDown.Value = numericUpDown.Minimum = 1;
                    numericUpDown.Maximum = 24 * 30;
                    break;
                case "天":
                    numericUpDown.Value = numericUpDown.Minimum = 1;
                    numericUpDown.Maximum = 30;
                    break;
            }
            Console.WriteLine("min: {0} max: {1}", numericUpDown.Minimum, numericUpDown.Maximum);
        }

        /// <summary>
        /// 选择自动备份周期的numericupdown控件
        /// </summary>
        private void BackupCycleNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!Resource.InitFinished)
            {
                return;
            }
            Local.Config.ConfigInstance.GlobalBackupSettings.BackupTime.Time = Convert.ToInt32(BackupCycleNumericUpDown.Value);
        }
        /// <summary>
        /// 选择备份有效期的numericupdown控件
        /// </summary>
        private void BackupExpiredNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (!Resource.InitFinished)
            {
                return;
            }
            Local.Config.ConfigInstance.GlobalBackupSettings.ExpiredTime.Time = Convert.ToInt32(BackupExpiredNumericUpDown.Value);
        }
        /// <summary>
        /// 自动备份周期的时间单位(combobox控件)
        /// </summary>
        private void BackupCycleUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Resource.InitFinished)
            {
                return;
            }
            else
            {
                LimitNumericUpDownValue(BackupCycleUnit, BackupCycleNumericUpDown);
            }
            Local.Config.ConfigInstance.GlobalBackupSettings.BackupTime.Unit = (BackupCycleUnit.Tag as List<TimeUnitEnum>)[BackupCycleUnit.SelectedIndex];
        }
        /// <summary>
        /// 备份有效期的时间单位(combobox控件)
        /// </summary>
        private void BackupExpiredUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Resource.InitFinished)
            {
                return;
            }
            else
            {
                LimitNumericUpDownValue(BackupExpiredUnit, BackupExpiredNumericUpDown);
            }
            Local.Config.ConfigInstance.GlobalBackupSettings.ExpiredTime.Unit = (BackupExpiredUnit.Tag as List<TimeUnitEnum>)[BackupExpiredUnit.SelectedIndex];
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

    }
}
