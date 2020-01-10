using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public void Log(string msg, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0)
        {
            textBox1.AppendText($"[{DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")}][{sourceFilePath},{memberName},{sourceLineNumber}] {msg}{Environment.NewLine}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Log("测试1");
            Log(Local.Config.GlobalPath);
        }
    }
}
