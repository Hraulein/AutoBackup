namespace AutoBackup.Model
{
    partial class SettingForm
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
            this.BtnInstallService = new System.Windows.Forms.Button();
            this.BtnStartService = new System.Windows.Forms.Button();
            this.GrpWinService = new System.Windows.Forms.GroupBox();
            this.GrpBackupSettings = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.LabBackupState = new System.Windows.Forms.Label();
            this.PnlADSettings = new System.Windows.Forms.Panel();
            this.CmbADTime = new System.Windows.Forms.ComboBox();
            this.PnlABSettings = new System.Windows.Forms.Panel();
            this.CmbABTime = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChkIncBackup = new System.Windows.Forms.CheckBox();
            this.ChkAllBackup = new System.Windows.Forms.CheckBox();
            this.ChkAutoDelete = new System.Windows.Forms.CheckBox();
            this.ChkAutoBackup = new System.Windows.Forms.CheckBox();
            this.BtnOptRootDir = new System.Windows.Forms.Button();
            this.TxtShowRootDir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GrpOthers = new System.Windows.Forms.GroupBox();
            this.BtnCheckUpdate = new System.Windows.Forms.Button();
            this.BtnSystemLog = new System.Windows.Forms.Button();
            this.BtnUpdateLog = new System.Windows.Forms.Button();
            this.BtnContactUs = new System.Windows.Forms.Button();
            this.BtnDevelopers = new System.Windows.Forms.Button();
            this.BtnInstructions = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.GrpWinService.SuspendLayout();
            this.GrpBackupSettings.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.PnlADSettings.SuspendLayout();
            this.PnlABSettings.SuspendLayout();
            this.GrpOthers.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnInstallService
            // 
            this.BtnInstallService.Location = new System.Drawing.Point(57, 30);
            this.BtnInstallService.Name = "BtnInstallService";
            this.BtnInstallService.Size = new System.Drawing.Size(138, 32);
            this.BtnInstallService.TabIndex = 1;
            this.BtnInstallService.Text = "安装";
            this.BtnInstallService.UseVisualStyleBackColor = true;
            // 
            // BtnStartService
            // 
            this.BtnStartService.Location = new System.Drawing.Point(270, 30);
            this.BtnStartService.Name = "BtnStartService";
            this.BtnStartService.Size = new System.Drawing.Size(138, 32);
            this.BtnStartService.TabIndex = 2;
            this.BtnStartService.Text = "启动";
            this.BtnStartService.UseVisualStyleBackColor = true;
            // 
            // GrpWinService
            // 
            this.GrpWinService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpWinService.Controls.Add(this.BtnInstallService);
            this.GrpWinService.Controls.Add(this.BtnStartService);
            this.GrpWinService.Location = new System.Drawing.Point(8, 5);
            this.GrpWinService.Name = "GrpWinService";
            this.GrpWinService.Size = new System.Drawing.Size(477, 83);
            this.GrpWinService.TabIndex = 2;
            this.GrpWinService.TabStop = false;
            this.GrpWinService.Text = "Windows服务";
            // 
            // GrpBackupSettings
            // 
            this.GrpBackupSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBackupSettings.Controls.Add(this.groupBox4);
            this.GrpBackupSettings.Controls.Add(this.BtnOptRootDir);
            this.GrpBackupSettings.Controls.Add(this.TxtShowRootDir);
            this.GrpBackupSettings.Controls.Add(this.label1);
            this.GrpBackupSettings.Location = new System.Drawing.Point(8, 94);
            this.GrpBackupSettings.Name = "GrpBackupSettings";
            this.GrpBackupSettings.Size = new System.Drawing.Size(477, 229);
            this.GrpBackupSettings.TabIndex = 0;
            this.GrpBackupSettings.TabStop = false;
            this.GrpBackupSettings.Text = "全局设置";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.LabBackupState);
            this.groupBox4.Controls.Add(this.PnlADSettings);
            this.groupBox4.Controls.Add(this.PnlABSettings);
            this.groupBox4.Controls.Add(this.ChkAutoDelete);
            this.groupBox4.Controls.Add(this.ChkAutoBackup);
            this.groupBox4.Location = new System.Drawing.Point(9, 43);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(457, 178);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // LabBackupState
            // 
            this.LabBackupState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabBackupState.ForeColor = System.Drawing.Color.Red;
            this.LabBackupState.Location = new System.Drawing.Point(6, 104);
            this.LabBackupState.Name = "LabBackupState";
            this.LabBackupState.Padding = new System.Windows.Forms.Padding(5);
            this.LabBackupState.Size = new System.Drawing.Size(442, 63);
            this.LabBackupState.TabIndex = 2;
            this.LabBackupState.Text = "是否启用自动备份: 否\r\n是否启用自动删除: 否\r\n下次自动备份时间: yyyy/MM/dd HH:mm";
            // 
            // PnlADSettings
            // 
            this.PnlADSettings.Controls.Add(this.CmbADTime);
            this.PnlADSettings.Location = new System.Drawing.Point(108, 51);
            this.PnlADSettings.Name = "PnlADSettings";
            this.PnlADSettings.Size = new System.Drawing.Size(340, 36);
            this.PnlADSettings.TabIndex = 0;
            this.PnlADSettings.Visible = false;
            // 
            // CmbADTime
            // 
            this.CmbADTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbADTime.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CmbADTime.FormattingEnabled = true;
            this.CmbADTime.Items.AddRange(new object[] {
            "   删除一天前的备份",
            "   删除三天前的备份",
            "   删除五天前的备份",
            "   删除七天前的备份"});
            this.CmbADTime.Location = new System.Drawing.Point(6, 6);
            this.CmbADTime.Name = "CmbADTime";
            this.CmbADTime.Size = new System.Drawing.Size(319, 24);
            this.CmbADTime.TabIndex = 0;
            // 
            // PnlABSettings
            // 
            this.PnlABSettings.Controls.Add(this.CmbABTime);
            this.PnlABSettings.Controls.Add(this.label3);
            this.PnlABSettings.Controls.Add(this.ChkIncBackup);
            this.PnlABSettings.Controls.Add(this.ChkAllBackup);
            this.PnlABSettings.Location = new System.Drawing.Point(108, 12);
            this.PnlABSettings.Name = "PnlABSettings";
            this.PnlABSettings.Size = new System.Drawing.Size(340, 36);
            this.PnlABSettings.TabIndex = 5;
            this.PnlABSettings.Visible = false;
            // 
            // CmbABTime
            // 
            this.CmbABTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbABTime.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CmbABTime.FormattingEnabled = true;
            this.CmbABTime.Items.AddRange(new object[] {
            "   每天",
            "   三天",
            "   每周",
            "   半月"});
            this.CmbABTime.Location = new System.Drawing.Point(6, 6);
            this.CmbABTime.Name = "CmbABTime";
            this.CmbABTime.Size = new System.Drawing.Size(95, 24);
            this.CmbABTime.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "备份类型: ";
            // 
            // ChkIncBackup
            // 
            this.ChkIncBackup.AutoSize = true;
            this.ChkIncBackup.Location = new System.Drawing.Point(258, 10);
            this.ChkIncBackup.Name = "ChkIncBackup";
            this.ChkIncBackup.Size = new System.Drawing.Size(75, 21);
            this.ChkIncBackup.TabIndex = 3;
            this.ChkIncBackup.Text = "增量备份";
            this.ChkIncBackup.UseVisualStyleBackColor = true;
            // 
            // ChkAllBackup
            // 
            this.ChkAllBackup.AutoSize = true;
            this.ChkAllBackup.Location = new System.Drawing.Point(181, 10);
            this.ChkAllBackup.Name = "ChkAllBackup";
            this.ChkAllBackup.Size = new System.Drawing.Size(75, 21);
            this.ChkAllBackup.TabIndex = 2;
            this.ChkAllBackup.Text = "全部备份";
            this.ChkAllBackup.UseVisualStyleBackColor = true;
            // 
            // ChkAutoDelete
            // 
            this.ChkAutoDelete.AutoSize = true;
            this.ChkAutoDelete.Location = new System.Drawing.Point(9, 60);
            this.ChkAutoDelete.Name = "ChkAutoDelete";
            this.ChkAutoDelete.Size = new System.Drawing.Size(99, 21);
            this.ChkAutoDelete.TabIndex = 1;
            this.ChkAutoDelete.Text = "备份的有效期";
            this.ChkAutoDelete.UseVisualStyleBackColor = true;
            this.ChkAutoDelete.CheckedChanged += new System.EventHandler(this.ChkAutoDelete_CheckedChanged);
            // 
            // ChkAutoBackup
            // 
            this.ChkAutoBackup.AutoSize = true;
            this.ChkAutoBackup.Location = new System.Drawing.Point(9, 21);
            this.ChkAutoBackup.Name = "ChkAutoBackup";
            this.ChkAutoBackup.Size = new System.Drawing.Size(99, 21);
            this.ChkAutoBackup.TabIndex = 0;
            this.ChkAutoBackup.Text = "启用自动备份";
            this.ChkAutoBackup.UseVisualStyleBackColor = true;
            this.ChkAutoBackup.CheckedChanged += new System.EventHandler(this.ChkAutoBackup_CheckedChanged);
            // 
            // BtnOptRootDir
            // 
            this.BtnOptRootDir.Location = new System.Drawing.Point(398, 19);
            this.BtnOptRootDir.Name = "BtnOptRootDir";
            this.BtnOptRootDir.Size = new System.Drawing.Size(69, 25);
            this.BtnOptRootDir.TabIndex = 2;
            this.BtnOptRootDir.Text = "选择";
            this.BtnOptRootDir.UseVisualStyleBackColor = true;
            this.BtnOptRootDir.Click += new System.EventHandler(this.BtnOptRootDir_Click);
            // 
            // TxtShowRootDir
            // 
            this.TxtShowRootDir.Location = new System.Drawing.Point(112, 20);
            this.TxtShowRootDir.Name = "TxtShowRootDir";
            this.TxtShowRootDir.ReadOnly = true;
            this.TxtShowRootDir.Size = new System.Drawing.Size(273, 23);
            this.TxtShowRootDir.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "备份的保存目录: ";
            // 
            // GrpOthers
            // 
            this.GrpOthers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpOthers.Controls.Add(this.BtnCheckUpdate);
            this.GrpOthers.Controls.Add(this.BtnSystemLog);
            this.GrpOthers.Controls.Add(this.BtnUpdateLog);
            this.GrpOthers.Controls.Add(this.BtnContactUs);
            this.GrpOthers.Controls.Add(this.BtnDevelopers);
            this.GrpOthers.Controls.Add(this.BtnInstructions);
            this.GrpOthers.Controls.Add(this.label2);
            this.GrpOthers.Location = new System.Drawing.Point(8, 329);
            this.GrpOthers.Name = "GrpOthers";
            this.GrpOthers.Size = new System.Drawing.Size(477, 112);
            this.GrpOthers.TabIndex = 1;
            this.GrpOthers.TabStop = false;
            this.GrpOthers.Text = "其他";
            // 
            // BtnCheckUpdate
            // 
            this.BtnCheckUpdate.Location = new System.Drawing.Point(15, 53);
            this.BtnCheckUpdate.Name = "BtnCheckUpdate";
            this.BtnCheckUpdate.Size = new System.Drawing.Size(100, 25);
            this.BtnCheckUpdate.TabIndex = 3;
            this.BtnCheckUpdate.Text = "检查更新";
            this.BtnCheckUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnSystemLog
            // 
            this.BtnSystemLog.Location = new System.Drawing.Point(357, 22);
            this.BtnSystemLog.Name = "BtnSystemLog";
            this.BtnSystemLog.Size = new System.Drawing.Size(100, 25);
            this.BtnSystemLog.TabIndex = 2;
            this.BtnSystemLog.Text = "系统日志";
            this.BtnSystemLog.UseVisualStyleBackColor = true;
            // 
            // BtnUpdateLog
            // 
            this.BtnUpdateLog.Location = new System.Drawing.Point(188, 22);
            this.BtnUpdateLog.Name = "BtnUpdateLog";
            this.BtnUpdateLog.Size = new System.Drawing.Size(100, 25);
            this.BtnUpdateLog.TabIndex = 1;
            this.BtnUpdateLog.Text = "更新日志";
            this.BtnUpdateLog.UseVisualStyleBackColor = true;
            // 
            // BtnContactUs
            // 
            this.BtnContactUs.Location = new System.Drawing.Point(188, 53);
            this.BtnContactUs.Name = "BtnContactUs";
            this.BtnContactUs.Size = new System.Drawing.Size(100, 25);
            this.BtnContactUs.TabIndex = 4;
            this.BtnContactUs.Text = "反馈与建议";
            this.BtnContactUs.UseVisualStyleBackColor = true;
            // 
            // BtnDevelopers
            // 
            this.BtnDevelopers.Location = new System.Drawing.Point(357, 53);
            this.BtnDevelopers.Name = "BtnDevelopers";
            this.BtnDevelopers.Size = new System.Drawing.Size(100, 25);
            this.BtnDevelopers.TabIndex = 5;
            this.BtnDevelopers.Text = "开发者信息";
            this.BtnDevelopers.UseVisualStyleBackColor = true;
            // 
            // BtnInstructions
            // 
            this.BtnInstructions.Location = new System.Drawing.Point(15, 22);
            this.BtnInstructions.Name = "BtnInstructions";
            this.BtnInstructions.Size = new System.Drawing.Size(100, 25);
            this.BtnInstructions.TabIndex = 0;
            this.BtnInstructions.Text = "使用说明";
            this.BtnInstructions.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(117, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "©COPYRIGHTS SK-STUDIO. ALL RIGHTS RESERVED";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 448);
            this.Controls.Add(this.GrpOthers);
            this.Controls.Add(this.GrpBackupSettings);
            this.Controls.Add(this.GrpWinService);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingForm_FormClosing);
            this.GrpWinService.ResumeLayout(false);
            this.GrpBackupSettings.ResumeLayout(false);
            this.GrpBackupSettings.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.PnlADSettings.ResumeLayout(false);
            this.PnlABSettings.ResumeLayout(false);
            this.PnlABSettings.PerformLayout();
            this.GrpOthers.ResumeLayout(false);
            this.GrpOthers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnInstallService;
        private System.Windows.Forms.Button BtnStartService;
        private System.Windows.Forms.GroupBox GrpWinService;
        private System.Windows.Forms.GroupBox GrpBackupSettings;
        private System.Windows.Forms.GroupBox GrpOthers;
        private System.Windows.Forms.Button BtnOptRootDir;
        private System.Windows.Forms.TextBox TxtShowRootDir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PnlABSettings;
        private System.Windows.Forms.ComboBox CmbABTime;
        private System.Windows.Forms.CheckBox ChkIncBackup;
        private System.Windows.Forms.CheckBox ChkAllBackup;
        private System.Windows.Forms.CheckBox ChkAutoDelete;
        private System.Windows.Forms.CheckBox ChkAutoBackup;
        private System.Windows.Forms.Panel PnlADSettings;
        private System.Windows.Forms.ComboBox CmbADTime;
        private System.Windows.Forms.Label LabBackupState;
        private System.Windows.Forms.Button BtnCheckUpdate;
        private System.Windows.Forms.Button BtnSystemLog;
        private System.Windows.Forms.Button BtnUpdateLog;
        private System.Windows.Forms.Button BtnContactUs;
        private System.Windows.Forms.Button BtnDevelopers;
        private System.Windows.Forms.Button BtnInstructions;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}