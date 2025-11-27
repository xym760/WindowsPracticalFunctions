using System.Windows.Forms;

namespace WindowsPracticalFunctions
{
    partial class TimerForm
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
            this.timerComponent = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.btnFinish = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.listViewRecords = new System.Windows.Forms.ListView();
            this.column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxTimeLimit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTopShow = new System.Windows.Forms.Button();
            this.labelTotalTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAheadTime = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAverageTime = new System.Windows.Forms.Label();
            this.comboBoxPages = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTotalPages = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerComponent
            // 
            this.timerComponent.Interval = 200;
            this.timerComponent.Tick += new System.EventHandler(this.timerComponent_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(25, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "开始计时";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTime.Location = new System.Drawing.Point(410, 75);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(89, 19);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "00:00:00";
            this.labelTime.Click += new System.EventHandler(this.labelTime_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(106, 12);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 3;
            this.btnFinish.Text = "完成";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(187, 12);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // listViewRecords
            // 
            this.listViewRecords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column});
            this.listViewRecords.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listViewRecords.HideSelection = false;
            this.listViewRecords.Location = new System.Drawing.Point(25, 47);
            this.listViewRecords.Name = "listViewRecords";
            this.listViewRecords.Size = new System.Drawing.Size(306, 372);
            this.listViewRecords.TabIndex = 5;
            this.listViewRecords.UseCompatibleStateImageBehavior = false;
            this.listViewRecords.View = System.Windows.Forms.View.Details;
            this.listViewRecords.SelectedIndexChanged += new System.EventHandler(this.listViewRecords_SelectedIndexChanged);
            // 
            // column
            // 
            this.column.Text = "记录内容";
            this.column.Width = 560;
            // 
            // comboBoxTimeLimit
            // 
            this.comboBoxTimeLimit.FormattingEnabled = true;
            this.comboBoxTimeLimit.Location = new System.Drawing.Point(268, 14);
            this.comboBoxTimeLimit.Name = "comboBoxTimeLimit";
            this.comboBoxTimeLimit.Size = new System.Drawing.Size(101, 20);
            this.comboBoxTimeLimit.TabIndex = 6;
            this.comboBoxTimeLimit.Text = "时间限制";
            this.comboBoxTimeLimit.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimeLimit_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "分钟";
            // 
            // btnTopShow
            // 
            this.btnTopShow.Location = new System.Drawing.Point(505, 12);
            this.btnTopShow.Name = "btnTopShow";
            this.btnTopShow.Size = new System.Drawing.Size(75, 23);
            this.btnTopShow.TabIndex = 8;
            this.btnTopShow.Text = "置顶显示";
            this.btnTopShow.UseVisualStyleBackColor = true;
            this.btnTopShow.Click += new System.EventHandler(this.btnTopShow_Click);
            // 
            // labelTotalTime
            // 
            this.labelTotalTime.AutoSize = true;
            this.labelTotalTime.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTotalTime.Location = new System.Drawing.Point(410, 129);
            this.labelTotalTime.Name = "labelTotalTime";
            this.labelTotalTime.Size = new System.Drawing.Size(89, 19);
            this.labelTotalTime.TabIndex = 9;
            this.labelTotalTime.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(339, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "总耗时：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "领先：";
            // 
            // labelAheadTime
            // 
            this.labelAheadTime.AutoSize = true;
            this.labelAheadTime.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAheadTime.Location = new System.Drawing.Point(410, 102);
            this.labelAheadTime.Name = "labelAheadTime";
            this.labelAheadTime.Size = new System.Drawing.Size(89, 19);
            this.labelAheadTime.TabIndex = 12;
            this.labelAheadTime.Text = "00:00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "平均时间：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelAverageTime
            // 
            this.labelAverageTime.AutoSize = true;
            this.labelAverageTime.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAverageTime.Location = new System.Drawing.Point(410, 155);
            this.labelAverageTime.Name = "labelAverageTime";
            this.labelAverageTime.Size = new System.Drawing.Size(76, 19);
            this.labelAverageTime.TabIndex = 14;
            this.labelAverageTime.Text = "分钟/页";
            // 
            // comboBoxPages
            // 
            this.comboBoxPages.FormattingEnabled = true;
            this.comboBoxPages.Location = new System.Drawing.Point(410, 14);
            this.comboBoxPages.Name = "comboBoxPages";
            this.comboBoxPages.Size = new System.Drawing.Size(66, 20);
            this.comboBoxPages.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "页";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelTotalPages
            // 
            this.labelTotalPages.AutoSize = true;
            this.labelTotalPages.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTotalPages.Location = new System.Drawing.Point(337, 47);
            this.labelTotalPages.Name = "labelTotalPages";
            this.labelTotalPages.Size = new System.Drawing.Size(105, 21);
            this.labelTotalPages.TabIndex = 17;
            this.labelTotalPages.Text = "共完成0页";
            this.labelTotalPages.Click += new System.EventHandler(this.labelTotalPages_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "单次耗时：";
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelTotalPages);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxPages);
            this.Controls.Add(this.labelAverageTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelAheadTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTotalTime);
            this.Controls.Add(this.btnTopShow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTimeLimit);
            this.Controls.Add(this.listViewRecords);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.btnStart);
            this.Name = "TimerForm";
            this.Text = "计时器";
            this.Load += new System.EventHandler(this.TimerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerComponent;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.ListView listViewRecords;
        private ComboBox comboBoxTimeLimit;
        private Label label1;
        private ColumnHeader column;
        private Button btnTopShow;
        private Label labelTotalTime;
        private Label label2;
        private Label label3;
        private Label labelAheadTime;
        private Label label4;
        private Label labelAverageTime;
        private ComboBox comboBoxPages;
        private Label label5;
        private Label labelTotalPages;
        private Label label6;
    }
}