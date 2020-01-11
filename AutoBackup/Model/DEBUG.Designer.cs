namespace AutoBackup.Model
{
    partial class DEBUG
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.测试列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.测试按钮1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(666, 411);
            this.textBox1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.测试列表ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 测试列表ToolStripMenuItem
            // 
            this.测试列表ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.测试按钮1ToolStripMenuItem});
            this.测试列表ToolStripMenuItem.Name = "测试列表ToolStripMenuItem";
            this.测试列表ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.测试列表ToolStripMenuItem.Text = "测试列表";
            // 
            // 测试按钮1ToolStripMenuItem
            // 
            this.测试按钮1ToolStripMenuItem.Name = "测试按钮1ToolStripMenuItem";
            this.测试按钮1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.测试按钮1ToolStripMenuItem.Text = "测试按钮1";
            this.测试按钮1ToolStripMenuItem.Click += new System.EventHandler(this.测试按钮1ToolStripMenuItem_Click);
            // 
            // DEBUG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DEBUG";
            this.Text = "DEBUG";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DEBUG_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 测试列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 测试按钮1ToolStripMenuItem;
    }
}