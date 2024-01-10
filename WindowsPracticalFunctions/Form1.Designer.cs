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
            this.confirmButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(25, 376);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 5;
            this.confirmButton.Text = "确认";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 407);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirmButton);
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
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label2;
    }
}

