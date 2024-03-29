﻿namespace AutoBackup.Model
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
            this.LblBackupState = new System.Windows.Forms.Label();
            this.PnlADSettings = new System.Windows.Forms.Panel();
            this.BackupExpiredNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BackupExpiredUnit = new System.Windows.Forms.ComboBox();
            this.PnlABSettings = new System.Windows.Forms.Panel();
            this.IncRadioButton = new System.Windows.Forms.RadioButton();
            this.BackupCycleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FullRadioButton = new System.Windows.Forms.RadioButton();
            this.BackupCycleUnit = new System.Windows.Forms.ComboBox();
            this.ChkAutoDelete = new System.Windows.Forms.CheckBox();
            this.ChkAutoBackup = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.BackupExpiredNumericUpDown)).BeginInit();
            this.PnlABSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackupCycleNumericUpDown)).BeginInit();
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
            this.groupBox4.Controls.Add(this.LblBackupState);
            this.groupBox4.Controls.Add(this.PnlADSettings);
            this.groupBox4.Controls.Add(this.PnlABSettings);
            this.groupBox4.Controls.Add(this.ChkAutoDelete);
            this.groupBox4.Controls.Add(this.ChkAutoBackup);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(9, 43);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(457, 178);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // LblBackupState
            // 
            this.LblBackupState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblBackupState.ForeColor = System.Drawing.Color.Red;
            this.LblBackupState.Location = new System.Drawing.Point(6, 104);
            this.LblBackupState.Name = "LblBackupState";
            this.LblBackupState.Padding = new System.Windows.Forms.Padding(5);
            this.LblBackupState.Size = new System.Drawing.Size(442, 63);
            this.LblBackupState.TabIndex = 2;
            this.LblBackupState.Text = "是否启用自动备份: 否\r\n是否启用自动删除: 否\r\n下次自动备份时间: yyyy/MM/dd HH:mm";
            // 
            // PnlADSettings
            // 
            this.PnlADSettings.Controls.Add(this.BackupExpiredNumericUpDown);
            this.PnlADSettings.Controls.Add(this.BackupExpiredUnit);
            this.PnlADSettings.Location = new System.Drawing.Point(108, 50);
            this.PnlADSettings.Name = "PnlADSettings";
            this.PnlADSettings.Size = new System.Drawing.Size(340, 51);
            this.PnlADSettings.TabIndex = 0;
            this.PnlADSettings.Visible = false;
            // 
            // BackupExpiredNumericUpDown
            // 
            this.BackupExpiredNumericUpDown.Location = new System.Drawing.Point(9, 9);
            this.BackupExpiredNumericUpDown.Maximum = new decimal(new int[] {
            876000,
            0,
            0,
            0});
            this.BackupExpiredNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BackupExpiredNumericUpDown.Name = "BackupExpiredNumericUpDown";
            this.BackupExpiredNumericUpDown.Size = new System.Drawing.Size(80, 23);
            this.BackupExpiredNumericUpDown.TabIndex = 2;
            this.BackupExpiredNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BackupExpiredNumericUpDown.ValueChanged += new System.EventHandler(this.BackupExpiredNumericUpDown_ValueChanged);
            // 
            // BackupExpiredUnit
            // 
            this.BackupExpiredUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BackupExpiredUnit.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BackupExpiredUnit.FormattingEnabled = true;
            this.BackupExpiredUnit.Items.AddRange(new object[] {
            "分钟",
            "小时",
            "天",
            "月",
            "年"});
            this.BackupExpiredUnit.Location = new System.Drawing.Point(107, 9);
            this.BackupExpiredUnit.Name = "BackupExpiredUnit";
            this.BackupExpiredUnit.Size = new System.Drawing.Size(95, 24);
            this.BackupExpiredUnit.TabIndex = 0;
            this.BackupExpiredUnit.SelectedIndexChanged += new System.EventHandler(this.BackupExpiredUnit_SelectedIndexChanged);
            // 
            // PnlABSettings
            // 
            this.PnlABSettings.Controls.Add(this.IncRadioButton);
            this.PnlABSettings.Controls.Add(this.BackupCycleNumericUpDown);
            this.PnlABSettings.Controls.Add(this.FullRadioButton);
            this.PnlABSettings.Controls.Add(this.BackupCycleUnit);
            this.PnlABSettings.Location = new System.Drawing.Point(108, 12);
            this.PnlABSettings.Name = "PnlABSettings";
            this.PnlABSettings.Size = new System.Drawing.Size(340, 36);
            this.PnlABSettings.TabIndex = 5;
            this.PnlABSettings.Visible = false;
            // 
            // IncRadioButton
            // 
            this.IncRadioButton.AutoSize = true;
            this.IncRadioButton.Location = new System.Drawing.Point(281, 8);
            this.IncRadioButton.Name = "IncRadioButton";
            this.IncRadioButton.Size = new System.Drawing.Size(50, 21);
            this.IncRadioButton.TabIndex = 4;
            this.IncRadioButton.TabStop = true;
            this.IncRadioButton.Text = "增量";
            this.IncRadioButton.UseVisualStyleBackColor = true;
            // 
            // BackupCycleNumericUpDown
            // 
            this.BackupCycleNumericUpDown.Location = new System.Drawing.Point(9, 6);
            this.BackupCycleNumericUpDown.Maximum = new decimal(new int[] {
            876000,
            0,
            0,
            0});
            this.BackupCycleNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BackupCycleNumericUpDown.Name = "BackupCycleNumericUpDown";
            this.BackupCycleNumericUpDown.Size = new System.Drawing.Size(80, 23);
            this.BackupCycleNumericUpDown.TabIndex = 2;
            this.BackupCycleNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BackupCycleNumericUpDown.ValueChanged += new System.EventHandler(this.BackupCycleNumericUpDown_ValueChanged);
            // 
            // FullRadioButton
            // 
            this.FullRadioButton.AutoSize = true;
            this.FullRadioButton.Location = new System.Drawing.Point(219, 8);
            this.FullRadioButton.Name = "FullRadioButton";
            this.FullRadioButton.Size = new System.Drawing.Size(50, 21);
            this.FullRadioButton.TabIndex = 3;
            this.FullRadioButton.TabStop = true;
            this.FullRadioButton.Text = "全量";
            this.FullRadioButton.UseVisualStyleBackColor = true;
            // 
            // BackupCycleUnit
            // 
            this.BackupCycleUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BackupCycleUnit.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BackupCycleUnit.FormattingEnabled = true;
            this.BackupCycleUnit.Location = new System.Drawing.Point(107, 6);
            this.BackupCycleUnit.Name = "BackupCycleUnit";
            this.BackupCycleUnit.Size = new System.Drawing.Size(95, 24);
            this.BackupCycleUnit.TabIndex = 0;
            this.BackupCycleUnit.SelectedIndexChanged += new System.EventHandler(this.BackupCycleUnit_SelectedIndexChanged);
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
            this.ChkAutoBackup.Text = "自动备份周期";
            this.ChkAutoBackup.UseVisualStyleBackColor = true;
            this.ChkAutoBackup.CheckedChanged += new System.EventHandler(this.ChkAutoBackup_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(114, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "备份永不过期";
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
            this.TxtShowRootDir.TextChanged += new System.EventHandler(this.TxtShowRootDir_TextChanged);
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
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.GrpWinService.ResumeLayout(false);
            this.GrpBackupSettings.ResumeLayout(false);
            this.GrpBackupSettings.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.PnlADSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BackupExpiredNumericUpDown)).EndInit();
            this.PnlABSettings.ResumeLayout(false);
            this.PnlABSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackupCycleNumericUpDown)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PnlABSettings;
        private System.Windows.Forms.ComboBox BackupCycleUnit;
        private System.Windows.Forms.CheckBox ChkAutoDelete;
        private System.Windows.Forms.CheckBox ChkAutoBackup;
        private System.Windows.Forms.Panel PnlADSettings;
        private System.Windows.Forms.ComboBox BackupExpiredUnit;
        private System.Windows.Forms.Label LblBackupState;
        private System.Windows.Forms.Button BtnCheckUpdate;
        private System.Windows.Forms.Button BtnSystemLog;
        private System.Windows.Forms.Button BtnUpdateLog;
        private System.Windows.Forms.Button BtnContactUs;
        private System.Windows.Forms.Button BtnDevelopers;
        private System.Windows.Forms.Button BtnInstructions;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown BackupExpiredNumericUpDown;
        private System.Windows.Forms.NumericUpDown BackupCycleNumericUpDown;
        private System.Windows.Forms.RadioButton IncRadioButton;
        private System.Windows.Forms.RadioButton FullRadioButton;
    }
}