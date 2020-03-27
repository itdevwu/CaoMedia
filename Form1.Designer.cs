namespace CaoMedia
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.inputPathBox = new System.Windows.Forms.TextBox();
            this.inputFileButton = new System.Windows.Forms.Button();
            this.convertProgressBar = new System.Windows.Forms.ProgressBar();
            this.outputPathTextBox = new System.Windows.Forms.TextBox();
            this.outputPathButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileOpTopStripe = new System.Windows.Forms.ToolStripMenuItem();
            this.exitTopStripe = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionTopStripe = new System.Windows.Forms.ToolStripMenuItem();
            this.formatComboBox = new System.Windows.Forms.ComboBox();
            this.ultrafastModeCheckBox = new System.Windows.Forms.CheckBox();
            this.startConvertButton = new System.Windows.Forms.Button();
            this.formatLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputPathBox
            // 
            this.inputPathBox.AllowDrop = true;
            this.inputPathBox.Location = new System.Drawing.Point(8, 32);
            this.inputPathBox.Name = "inputPathBox";
            this.inputPathBox.Size = new System.Drawing.Size(474, 25);
            this.inputPathBox.TabIndex = 0;
            this.inputPathBox.TextChanged += new System.EventHandler(this.inputPathBox_TextChanged);
            // 
            // inputFileButton
            // 
            this.inputFileButton.Location = new System.Drawing.Point(401, 32);
            this.inputFileButton.Name = "inputFileButton";
            this.inputFileButton.Size = new System.Drawing.Size(81, 25);
            this.inputFileButton.TabIndex = 1;
            this.inputFileButton.Text = "选择文件";
            this.inputFileButton.UseVisualStyleBackColor = true;
            this.inputFileButton.Click += new System.EventHandler(this.selectFile_Click);
            // 
            // convertProgressBar
            // 
            this.convertProgressBar.Location = new System.Drawing.Point(8, 94);
            this.convertProgressBar.Name = "convertProgressBar";
            this.convertProgressBar.Size = new System.Drawing.Size(474, 23);
            this.convertProgressBar.TabIndex = 2;
            // 
            // outputPathTextBox
            // 
            this.outputPathTextBox.Location = new System.Drawing.Point(8, 63);
            this.outputPathTextBox.Name = "outputPathTextBox";
            this.outputPathTextBox.Size = new System.Drawing.Size(474, 25);
            this.outputPathTextBox.TabIndex = 3;
            // 
            // outputPathButton
            // 
            this.outputPathButton.Location = new System.Drawing.Point(401, 65);
            this.outputPathButton.Name = "outputPathButton";
            this.outputPathButton.Size = new System.Drawing.Size(81, 23);
            this.outputPathButton.TabIndex = 4;
            this.outputPathButton.Text = "选择位置";
            this.outputPathButton.UseVisualStyleBackColor = true;
            this.outputPathButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileOpTopStripe,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(489, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileOpTopStripe
            // 
            this.fileOpTopStripe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitTopStripe});
            this.fileOpTopStripe.Font = new System.Drawing.Font("思源黑体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fileOpTopStripe.Name = "fileOpTopStripe";
            this.fileOpTopStripe.Size = new System.Drawing.Size(44, 21);
            this.fileOpTopStripe.Text = "文件";
            // 
            // exitTopStripe
            // 
            this.exitTopStripe.Name = "exitTopStripe";
            this.exitTopStripe.Size = new System.Drawing.Size(100, 22);
            this.exitTopStripe.Text = "退出";
            this.exitTopStripe.Click += new System.EventHandler(this.exitTopStripe_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionTopStripe});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // versionTopStripe
            // 
            this.versionTopStripe.Font = new System.Drawing.Font("思源黑体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.versionTopStripe.Name = "versionTopStripe";
            this.versionTopStripe.Size = new System.Drawing.Size(124, 22);
            this.versionTopStripe.Text = "版本信息";
            this.versionTopStripe.Click += new System.EventHandler(this.versionTopStripe_Click);
            // 
            // formatComboBox
            // 
            this.formatComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.formatComboBox.FormattingEnabled = true;
            this.formatComboBox.Items.AddRange(new object[] {
            "mp4",
            "hevc",
            "wmi",
            "mov",
            "m4v",
            "avi",
            "mkv",
            "mp3",
            "ogg",
            "aac",
            "flac"});
            this.formatComboBox.Location = new System.Drawing.Point(91, 123);
            this.formatComboBox.Name = "formatComboBox";
            this.formatComboBox.Size = new System.Drawing.Size(105, 25);
            this.formatComboBox.TabIndex = 6;
            this.formatComboBox.Text = "选择输出格式";
            // 
            // ultrafastModeCheckBox
            // 
            this.ultrafastModeCheckBox.AutoSize = true;
            this.ultrafastModeCheckBox.Location = new System.Drawing.Point(202, 125);
            this.ultrafastModeCheckBox.Name = "ultrafastModeCheckBox";
            this.ultrafastModeCheckBox.Size = new System.Drawing.Size(75, 21);
            this.ultrafastModeCheckBox.TabIndex = 7;
            this.ultrafastModeCheckBox.Text = "极速模式";
            this.ultrafastModeCheckBox.UseVisualStyleBackColor = true;
            this.ultrafastModeCheckBox.CheckedChanged += new System.EventHandler(this.ultrafastModeCheckBox_CheckedChanged);
            // 
            // startConvertButton
            // 
            this.startConvertButton.Location = new System.Drawing.Point(283, 123);
            this.startConvertButton.Name = "startConvertButton";
            this.startConvertButton.Size = new System.Drawing.Size(199, 25);
            this.startConvertButton.TabIndex = 9;
            this.startConvertButton.Text = "开始处理";
            this.startConvertButton.UseVisualStyleBackColor = true;
            this.startConvertButton.Click += new System.EventHandler(this.startConvertButton_Click);
            // 
            // formatLabel
            // 
            this.formatLabel.AutoSize = true;
            this.formatLabel.Location = new System.Drawing.Point(5, 126);
            this.formatLabel.Name = "formatLabel";
            this.formatLabel.Size = new System.Drawing.Size(80, 17);
            this.formatLabel.TabIndex = 10;
            this.formatLabel.Text = "目标文件格式";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 155);
            this.Controls.Add(this.formatLabel);
            this.Controls.Add(this.startConvertButton);
            this.Controls.Add(this.ultrafastModeCheckBox);
            this.Controls.Add(this.formatComboBox);
            this.Controls.Add(this.outputPathButton);
            this.Controls.Add(this.outputPathTextBox);
            this.Controls.Add(this.convertProgressBar);
            this.Controls.Add(this.inputFileButton);
            this.Controls.Add(this.inputPathBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("思源黑体", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "mainForm";
            this.Text = "CaoMedia";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputPathBox;
        private System.Windows.Forms.Button inputFileButton;
        private System.Windows.Forms.ProgressBar convertProgressBar;
        private System.Windows.Forms.TextBox outputPathTextBox;
        private System.Windows.Forms.Button outputPathButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileOpTopStripe;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionTopStripe;
        private System.Windows.Forms.ToolStripMenuItem exitTopStripe;
        private System.Windows.Forms.ComboBox formatComboBox;
        private System.Windows.Forms.CheckBox ultrafastModeCheckBox;
        private System.Windows.Forms.Button startConvertButton;
        private System.Windows.Forms.Label formatLabel;
    }
}

