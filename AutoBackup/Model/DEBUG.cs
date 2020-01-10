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
    public partial class DEBUG : Form
    {
        public DEBUG()
        {
            InitializeComponent();
            Instance = this;
            Hide();
            ShowInTaskbar = false;
            WindowState = FormWindowState.Minimized;
        }

        public static DEBUG Instance = null;


        internal void ShowForm()
        {
            Invoke(new Action(() =>
            {
                Activate();
                WindowState = FormWindowState.Normal;
                Show();
            }));
        }

        internal void HideForm()
        {
            Invoke(new Action(() => { Hide(); }));
        }

        private void DEBUG_FormClosing(object sender, FormClosingEventArgs e)
        {
            HideForm();
            e.Cancel = true;
        }
    }
}
