namespace AutoBackup
{
    partial class ManagerForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.BtnIncBackup = new System.Windows.Forms.Button();
            this.BtnOptBackup = new System.Windows.Forms.Button();
            this.BtnNowBackup = new System.Windows.Forms.Button();
            this.BtnCheckState = new System.Windows.Forms.Button();
            this.BtnOpenRootDir = new System.Windows.Forms.Button();
            this.BtnDelRows = new System.Windows.Forms.Button();
            this.BtnAddFolders = new System.Windows.Forms.Button();
            this.BtnAddFiles = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblStatistics = new System.Windows.Forms.Label();
            this.BackupList = new System.Windows.Forms.ListView();
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backupPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.compress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CmsMouseRightList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddFoldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelRowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AttributeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.CmsMouseRightList.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.BtnSettings);
            this.groupBox1.Controls.Add(this.BtnIncBackup);
            this.groupBox1.Controls.Add(this.BtnOptBackup);
            this.groupBox1.Controls.Add(this.BtnNowBackup);
            this.groupBox1.Controls.Add(this.BtnCheckState);
            this.groupBox1.Controls.Add(this.BtnOpenRootDir);
            this.groupBox1.Controls.Add(this.BtnDelRows);
            this.groupBox1.Controls.Add(this.BtnAddFolders);
            this.groupBox1.Controls.Add(this.BtnAddFiles);
            this.groupBox1.Location = new System.Drawing.Point(8, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(194, 636);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作界面";
            // 
            // BtnSettings
            // 
            this.BtnSettings.Location = new System.Drawing.Point(35, 565);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(120, 32);
            this.BtnSettings.TabIndex = 8;
            this.BtnSettings.Text = "进入设置";
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnIncBackup
            // 
            this.BtnIncBackup.Location = new System.Drawing.Point(35, 501);
            this.BtnIncBackup.Name = "BtnIncBackup";
            this.BtnIncBackup.Size = new System.Drawing.Size(120, 32);
            this.BtnIncBackup.TabIndex = 7;
            this.BtnIncBackup.Text = "增量备份";
            this.BtnIncBackup.UseVisualStyleBackColor = true;
            // 
            // BtnOptBackup
            // 
            this.BtnOptBackup.Location = new System.Drawing.Point(35, 437);
            this.BtnOptBackup.Name = "BtnOptBackup";
            this.BtnOptBackup.Size = new System.Drawing.Size(120, 32);
            this.BtnOptBackup.TabIndex = 6;
            this.BtnOptBackup.Text = "选择备份";
            this.BtnOptBackup.UseVisualStyleBackColor = true;
            // 
            // BtnNowBackup
            // 
            this.BtnNowBackup.Location = new System.Drawing.Point(35, 373);
            this.BtnNowBackup.Name = "BtnNowBackup";
            this.BtnNowBackup.Size = new System.Drawing.Size(120, 32);
            this.BtnNowBackup.TabIndex = 5;
            this.BtnNowBackup.Text = "立即备份";
            this.BtnNowBackup.UseVisualStyleBackColor = true;
            // 
            // BtnCheckState
            // 
            this.BtnCheckState.Location = new System.Drawing.Point(35, 309);
            this.BtnCheckState.Name = "BtnCheckState";
            this.BtnCheckState.Size = new System.Drawing.Size(120, 32);
            this.BtnCheckState.TabIndex = 4;
            this.BtnCheckState.Text = "检查列表状态";
            this.BtnCheckState.UseVisualStyleBackColor = true;
            this.BtnCheckState.Click += new System.EventHandler(this.BtnCheckState_Click);
            // 
            // BtnOpenRootDir
            // 
            this.BtnOpenRootDir.Location = new System.Drawing.Point(35, 245);
            this.BtnOpenRootDir.Name = "BtnOpenRootDir";
            this.BtnOpenRootDir.Size = new System.Drawing.Size(120, 32);
            this.BtnOpenRootDir.TabIndex = 3;
            this.BtnOpenRootDir.Text = "打开备份目录";
            this.BtnOpenRootDir.UseVisualStyleBackColor = true;
            // 
            // BtnDelRows
            // 
            this.BtnDelRows.Location = new System.Drawing.Point(35, 181);
            this.BtnDelRows.Name = "BtnDelRows";
            this.BtnDelRows.Size = new System.Drawing.Size(120, 32);
            this.BtnDelRows.TabIndex = 2;
            this.BtnDelRows.Text = "删除列表项目";
            this.BtnDelRows.UseVisualStyleBackColor = true;
            this.BtnDelRows.Click += new System.EventHandler(this.BtnDelRows_Click);
            // 
            // BtnAddFolders
            // 
            this.BtnAddFolders.Location = new System.Drawing.Point(35, 117);
            this.BtnAddFolders.Name = "BtnAddFolders";
            this.BtnAddFolders.Size = new System.Drawing.Size(120, 32);
            this.BtnAddFolders.TabIndex = 1;
            this.BtnAddFolders.Text = "添加文件夹";
            this.BtnAddFolders.UseVisualStyleBackColor = true;
            this.BtnAddFolders.Click += new System.EventHandler(this.BtnAddFolders_Click);
            // 
            // BtnAddFiles
            // 
            this.BtnAddFiles.Location = new System.Drawing.Point(35, 53);
            this.BtnAddFiles.Name = "BtnAddFiles";
            this.BtnAddFiles.Size = new System.Drawing.Size(120, 32);
            this.BtnAddFiles.TabIndex = 0;
            this.BtnAddFiles.Text = "添加文件";
            this.BtnAddFiles.UseVisualStyleBackColor = true;
            this.BtnAddFiles.Click += new System.EventHandler(this.BtnAddFiles_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.LblStatistics);
            this.groupBox2.Controls.Add(this.BackupList);
            this.groupBox2.Location = new System.Drawing.Point(208, 1);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(795, 636);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "备份列表";
            // 
            // LblStatistics
            // 
            this.LblStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblStatistics.BackColor = System.Drawing.Color.White;
            this.LblStatistics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblStatistics.Location = new System.Drawing.Point(6, 604);
            this.LblStatistics.Name = "LblStatistics";
            this.LblStatistics.Size = new System.Drawing.Size(783, 25);
            this.LblStatistics.TabIndex = 9;
            this.LblStatistics.Text = "统计数据:    文件:    x 个    丨    文件夹:    x 个    丨    总大小:    x MB    丨    无效文件:    x 个" +
    "    丨    无效目录:    x 个";
            this.LblStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackupList
            // 
            this.BackupList.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.BackupList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackupList.BackColor = System.Drawing.Color.White;
            this.BackupList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.type,
            this.status,
            this.path,
            this.size,
            this.lastTime,
            this.backupPath,
            this.compress});
            this.BackupList.ContextMenuStrip = this.CmsMouseRightList;
            this.BackupList.FullRowSelect = true;
            this.BackupList.GridLines = true;
            this.BackupList.HideSelection = false;
            this.BackupList.Location = new System.Drawing.Point(6, 17);
            this.BackupList.Name = "BackupList";
            this.BackupList.ShowItemToolTips = true;
            this.BackupList.Size = new System.Drawing.Size(783, 580);
            this.BackupList.SmallImageList = this.imageList1;
            this.BackupList.TabIndex = 8;
            this.BackupList.TabStop = false;
            this.BackupList.Tag = "";
            this.BackupList.UseCompatibleStateImageBehavior = false;
            this.BackupList.View = System.Windows.Forms.View.Details;
            this.BackupList.DragEnter += new System.Windows.Forms.DragEventHandler(this.BackupList_DragEnter);
            this.BackupList.DragOver += new System.Windows.Forms.DragEventHandler(this.BackupList_DragOver);
            this.BackupList.DragLeave += new System.EventHandler(this.BackupList_DragLeave);
            this.BackupList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BackupList_KeyDown);
            // 
            // type
            // 
            this.type.Text = "类型";
            this.type.Width = 100;
            // 
            // status
            // 
            this.status.Text = "状态";
            this.status.Width = 40;
            // 
            // path
            // 
            this.path.Text = "路径";
            this.path.Width = 222;
            // 
            // size
            // 
            this.size.Text = "大小";
            this.size.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.size.Width = 95;
            // 
            // lastTime
            // 
            this.lastTime.Text = "上次备份时间";
            this.lastTime.Width = 122;
            // 
            // backupPath
            // 
            this.backupPath.Text = "备份保存路径";
            this.backupPath.Width = 100;
            // 
            // compress
            // 
            this.compress.Text = "是否压缩";
            this.compress.Width = 100;
            // 
            // CmsMouseRightList
            // 
            this.CmsMouseRightList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddFilesToolStripMenuItem,
            this.AddFoldersToolStripMenuItem,
            this.DelRowsToolStripMenuItem,
            this.AttributeToolStripMenuItem});
            this.CmsMouseRightList.Name = "CmsMouseRightList";
            this.CmsMouseRightList.Size = new System.Drawing.Size(152, 92);
            this.CmsMouseRightList.Opened += new System.EventHandler(this.CmsMouseRightList_Opened);
            // 
            // AddFilesToolStripMenuItem
            // 
            this.AddFilesToolStripMenuItem.Name = "AddFilesToolStripMenuItem";
            this.AddFilesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.AddFilesToolStripMenuItem.Text = "添加文件(&E)";
            this.AddFilesToolStripMenuItem.Click += new System.EventHandler(this.AddFilesToolStripMenuItem_Click);
            // 
            // AddFoldersToolStripMenuItem
            // 
            this.AddFoldersToolStripMenuItem.Name = "AddFoldersToolStripMenuItem";
            this.AddFoldersToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.AddFoldersToolStripMenuItem.Text = "添加文件夹(&T)";
            this.AddFoldersToolStripMenuItem.Click += new System.EventHandler(this.AddFoldersToolStripMenuItem_Click);
            // 
            // DelRowsToolStripMenuItem
            // 
            this.DelRowsToolStripMenuItem.Name = "DelRowsToolStripMenuItem";
            this.DelRowsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.DelRowsToolStripMenuItem.Text = "删除项目(&D)";
            this.DelRowsToolStripMenuItem.Click += new System.EventHandler(this.DelRowsToolStripMenuItem_Click);
            // 
            // AttributeToolStripMenuItem
            // 
            this.AttributeToolStripMenuItem.Name = "AttributeToolStripMenuItem";
            this.AttributeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.AttributeToolStripMenuItem.Text = "属性(&P)";
            this.AttributeToolStripMenuItem.Click += new System.EventHandler(this.AttributeToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 643);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoBackup v1.0.0";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.CmsMouseRightList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LblStatistics;
        private System.Windows.Forms.ListView BackupList;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader path;
        private System.Windows.Forms.ColumnHeader size;
        private System.Windows.Forms.ColumnHeader lastTime;
        private System.Windows.Forms.ColumnHeader backupPath;
        private System.Windows.Forms.Button BtnDelRows;
        private System.Windows.Forms.Button BtnAddFolders;
        private System.Windows.Forms.Button BtnAddFiles;
        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Button BtnIncBackup;
        private System.Windows.Forms.Button BtnOptBackup;
        private System.Windows.Forms.Button BtnNowBackup;
        private System.Windows.Forms.Button BtnCheckState;
        private System.Windows.Forms.Button BtnOpenRootDir;
        private System.Windows.Forms.ContextMenuStrip CmsMouseRightList;
        private System.Windows.Forms.ToolStripMenuItem AddFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddFoldersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelRowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AttributeToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader compress;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ImageList imageList1;
    }
}