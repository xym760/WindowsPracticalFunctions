namespace WindowsPracticalFunctions
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.folderPathTextBox = new System.Windows.Forms.TextBox();
            this.chooseFolderButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.fileExtensionComboBox = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.appendingSuffixCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGenerateIco = new System.Windows.Forms.Button();
            this.btnTopShow = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(22, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "批量更改后缀名：";
            // 
            // folderPathTextBox
            // 
            this.folderPathTextBox.AllowDrop = true;
            this.folderPathTextBox.Location = new System.Drawing.Point(25, 129);
            this.folderPathTextBox.Multiline = true;
            this.folderPathTextBox.Name = "folderPathTextBox";
            this.folderPathTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.folderPathTextBox.Size = new System.Drawing.Size(795, 241);
            this.folderPathTextBox.TabIndex = 1;
            this.folderPathTextBox.Text = "可拖拽多个文件";
            this.folderPathTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.FolderPathTextBox_DragDrop);
            this.folderPathTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.folderPathTextBox_DragEnter);
            // 
            // chooseFolderButton
            // 
            this.chooseFolderButton.Location = new System.Drawing.Point(146, 65);
            this.chooseFolderButton.Name = "chooseFolderButton";
            this.chooseFolderButton.Size = new System.Drawing.Size(75, 23);
            this.chooseFolderButton.TabIndex = 2;
            this.chooseFolderButton.Text = "选择文件夹";
            this.chooseFolderButton.UseVisualStyleBackColor = true;
            this.chooseFolderButton.Click += new System.EventHandler(this.ChooseFolderButton_Click);
            // 
            // fileExtensionComboBox
            // 
            this.fileExtensionComboBox.FormattingEnabled = true;
            this.fileExtensionComboBox.Location = new System.Drawing.Point(227, 67);
            this.fileExtensionComboBox.Name = "fileExtensionComboBox";
            this.fileExtensionComboBox.Size = new System.Drawing.Size(121, 20);
            this.fileExtensionComboBox.TabIndex = 4;
            this.fileExtensionComboBox.Text = "输入文件后缀名";
            this.fileExtensionComboBox.SelectedIndexChanged += new System.EventHandler(this.fileExtensionComboBox_SelectedIndexChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(25, 376);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(22, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "如下文件将被修改后缀名：";
            // 
            // appendingSuffixCheckBox
            // 
            this.appendingSuffixCheckBox.AutoSize = true;
            this.appendingSuffixCheckBox.Location = new System.Drawing.Point(355, 70);
            this.appendingSuffixCheckBox.Name = "appendingSuffixCheckBox";
            this.appendingSuffixCheckBox.Size = new System.Drawing.Size(84, 16);
            this.appendingSuffixCheckBox.TabIndex = 8;
            this.appendingSuffixCheckBox.Text = "附加后缀名";
            this.appendingSuffixCheckBox.UseVisualStyleBackColor = true;
            this.appendingSuffixCheckBox.CheckedChanged += new System.EventHandler(this.appendingSuffix_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(830, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnGenerateIco
            // 
            this.btnGenerateIco.Location = new System.Drawing.Point(25, 41);
            this.btnGenerateIco.Name = "btnGenerateIco";
            this.btnGenerateIco.Size = new System.Drawing.Size(87, 23);
            this.btnGenerateIco.TabIndex = 10;
            this.btnGenerateIco.Text = "生成ico图标";
            this.btnGenerateIco.UseVisualStyleBackColor = true;
            this.btnGenerateIco.Click += new System.EventHandler(this.btnGenerateIco_Click);
            // 
            // btnTopShow
            // 
            this.btnTopShow.Location = new System.Drawing.Point(25, 13);
            this.btnTopShow.Name = "btnTopShow";
            this.btnTopShow.Size = new System.Drawing.Size(75, 23);
            this.btnTopShow.TabIndex = 11;
            this.btnTopShow.Text = "置顶显示";
            this.btnTopShow.UseVisualStyleBackColor = true;
            this.btnTopShow.Click += new System.EventHandler(this.btnTopShow_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(25, 406);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(75, 23);
            this.btnTimer.TabIndex = 12;
            this.btnTimer.Text = "计时器";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 486);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.btnTopShow);
            this.Controls.Add(this.btnGenerateIco);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.appendingSuffixCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.fileExtensionComboBox);
            this.Controls.Add(this.chooseFolderButton);
            this.Controls.Add(this.folderPathTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "实用工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox folderPathTextBox;
        private System.Windows.Forms.Button chooseFolderButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ComboBox fileExtensionComboBox;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox appendingSuffixCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGenerateIco;
        private System.Windows.Forms.Button btnTopShow;
        private System.Windows.Forms.Button btnTimer;
    }
}

