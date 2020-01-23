namespace AutoBackup.UI
{
    partial class ItemAttributeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblSourcePath = new System.Windows.Forms.Label();
            this.LblLastBackupTime = new System.Windows.Forms.Label();
            this.LblAttrName = new System.Windows.Forms.Label();
            this.LblAttrSize = new System.Windows.Forms.Label();
            this.LblAttrType = new System.Windows.Forms.Label();
            this.BtnCheckPath = new System.Windows.Forms.Button();
            this.CmbCompressionType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBackupSavePath = new System.Windows.Forms.TextBox();
            this.BtnApply = new System.Windows.Forms.Button();
            this.BtnAccept = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(17, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 1);
            this.label1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(14, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "上次备份时间:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(14, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "备份保存路径:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(14, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "压缩方式:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LblSourcePath);
            this.panel1.Controls.Add(this.LblLastBackupTime);
            this.panel1.Controls.Add(this.LblAttrName);
            this.panel1.Controls.Add(this.LblAttrSize);
            this.panel1.Controls.Add(this.LblAttrType);
            this.panel1.Controls.Add(this.BtnCheckPath);
            this.panel1.Controls.Add(this.CmbCompressionType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TxtBackupSavePath);
            this.panel1.Location = new System.Drawing.Point(8, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(384, 365);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // LblSourcePath
            // 
            this.LblSourcePath.AutoSize = true;
            this.LblSourcePath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblSourcePath.Location = new System.Drawing.Point(119, 99);
            this.LblSourcePath.Name = "LblSourcePath";
            this.LblSourcePath.Size = new System.Drawing.Size(207, 17);
            this.LblSourcePath.TabIndex = 11;
            this.LblSourcePath.Text = "E:\\3D Objects\\love-you-master.zip";
            // 
            // LblLastBackupTime
            // 
            this.LblLastBackupTime.AutoSize = true;
            this.LblLastBackupTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblLastBackupTime.Location = new System.Drawing.Point(119, 207);
            this.LblLastBackupTime.Name = "LblLastBackupTime";
            this.LblLastBackupTime.Size = new System.Drawing.Size(56, 17);
            this.LblLastBackupTime.TabIndex = 14;
            this.LblLastBackupTime.Text = "从未备份";
            // 
            // LblAttrName
            // 
            this.LblAttrName.AutoSize = true;
            this.LblAttrName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblAttrName.Location = new System.Drawing.Point(119, 15);
            this.LblAttrName.Name = "LblAttrName";
            this.LblAttrName.Size = new System.Drawing.Size(123, 17);
            this.LblAttrName.TabIndex = 13;
            this.LblAttrName.Text = "love-you-master.zip";
            // 
            // LblAttrSize
            // 
            this.LblAttrSize.AutoSize = true;
            this.LblAttrSize.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblAttrSize.Location = new System.Drawing.Point(119, 143);
            this.LblAttrSize.Name = "LblAttrSize";
            this.LblAttrSize.Size = new System.Drawing.Size(42, 17);
            this.LblAttrSize.TabIndex = 12;
            this.LblAttrSize.Text = "16 KB";
            // 
            // LblAttrType
            // 
            this.LblAttrType.AutoSize = true;
            this.LblAttrType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblAttrType.Location = new System.Drawing.Point(119, 57);
            this.LblAttrType.Name = "LblAttrType";
            this.LblAttrType.Size = new System.Drawing.Size(116, 17);
            this.LblAttrType.TabIndex = 10;
            this.LblAttrType.Text = "压缩(zipped)文件夹";
            // 
            // BtnCheckPath
            // 
            this.BtnCheckPath.Location = new System.Drawing.Point(295, 246);
            this.BtnCheckPath.Name = "BtnCheckPath";
            this.BtnCheckPath.Size = new System.Drawing.Size(71, 30);
            this.BtnCheckPath.TabIndex = 9;
            this.BtnCheckPath.Text = "更改(&C)...";
            this.BtnCheckPath.UseVisualStyleBackColor = true;
            this.BtnCheckPath.Click += new System.EventHandler(this.BtnCheckPath_Click);
            // 
            // CmbCompressionType
            // 
            this.CmbCompressionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCompressionType.FormattingEnabled = true;
            this.CmbCompressionType.Location = new System.Drawing.Point(119, 303);
            this.CmbCompressionType.Name = "CmbCompressionType";
            this.CmbCompressionType.Size = new System.Drawing.Size(247, 25);
            this.CmbCompressionType.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(14, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "名称:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(14, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "源路径:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(14, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "大小:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "类型:";
            // 
            // TxtBackupSavePath
            // 
            this.TxtBackupSavePath.BackColor = System.Drawing.Color.White;
            this.TxtBackupSavePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBackupSavePath.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.TxtBackupSavePath.Location = new System.Drawing.Point(119, 253);
            this.TxtBackupSavePath.Name = "TxtBackupSavePath";
            this.TxtBackupSavePath.ReadOnly = true;
            this.TxtBackupSavePath.Size = new System.Drawing.Size(173, 16);
            this.TxtBackupSavePath.TabIndex = 16;
            this.TxtBackupSavePath.Text = "[全局]E:\\Desktop";
            // 
            // BtnApply
            // 
            this.BtnApply.Location = new System.Drawing.Point(304, 393);
            this.BtnApply.Name = "BtnApply";
            this.BtnApply.Size = new System.Drawing.Size(88, 30);
            this.BtnApply.TabIndex = 16;
            this.BtnApply.Text = "应用(&A)";
            this.BtnApply.UseVisualStyleBackColor = true;
            // 
            // BtnAccept
            // 
            this.BtnAccept.Location = new System.Drawing.Point(115, 393);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(88, 30);
            this.BtnAccept.TabIndex = 0;
            this.BtnAccept.Text = "确定";
            this.BtnAccept.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(209, 393);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(88, 30);
            this.BtnCancel.TabIndex = 18;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // ItemAttributeForm
            // 
            this.AcceptButton = this.BtnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 440);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.BtnApply);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemAttributeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.ItemAttributeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnCheckPath;
        private System.Windows.Forms.ComboBox CmbCompressionType;
        private System.Windows.Forms.Label LblAttrName;
        private System.Windows.Forms.Label LblSourcePath;
        private System.Windows.Forms.Label LblAttrSize;
        private System.Windows.Forms.Label LblAttrType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBackupSavePath;
        private System.Windows.Forms.Label LblLastBackupTime;
        private System.Windows.Forms.Button BtnApply;
        private System.Windows.Forms.Button BtnAccept;
        private System.Windows.Forms.Button BtnCancel;
    }
}