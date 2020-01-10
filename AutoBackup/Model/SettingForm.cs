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

        private void ChkAutoBackup_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAutoBackup.Checked)
                PnlABSettings.Visible = true;
            else
                PnlABSettings.Visible = false;
        }

        private void ChkAutoDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkAutoDelete.Checked)
                PnlADSettings.Visible = true;
            else
                PnlADSettings.Visible = false;
        }

        private void SettingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("确定离开? 系统不会保留你所做的更改! ", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void BtnDevelopers_Click(object sender, EventArgs e)
        {

        }
    }
}
