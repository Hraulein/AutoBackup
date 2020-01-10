using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            new Thread(() => { Application.Run(new Model.DEBUG()); }) { IsBackground = true }.Start();
            InitializeComponent();
        }


        private void ManagerForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                Model.DEBUG.Instance.ShowForm();
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            Model.SettingForm setting = new Model.SettingForm();
            setting.ShowDialog();
        }
    }
}
