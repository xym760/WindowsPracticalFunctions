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
            this.SuspendLayout();
            // 
            // timerComponent
            // 
            this.timerComponent.Tick += new System.EventHandler(this.timerComponent_Tick);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(25, 36);
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
            this.labelTime.Location = new System.Drawing.Point(106, 41);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(53, 12);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "00:00:00";
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(165, 36);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 3;
            this.btnFinish.Text = "完成";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(246, 36);
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
            this.listViewRecords.Location = new System.Drawing.Point(25, 66);
            this.listViewRecords.Name = "listViewRecords";
            this.listViewRecords.Size = new System.Drawing.Size(562, 372);
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
            this.comboBoxTimeLimit.Location = new System.Drawing.Point(327, 38);
            this.comboBoxTimeLimit.Name = "comboBoxTimeLimit";
            this.comboBoxTimeLimit.Size = new System.Drawing.Size(121, 20);
            this.comboBoxTimeLimit.TabIndex = 6;
            this.comboBoxTimeLimit.Text = "时间限制（分钟）";
            this.comboBoxTimeLimit.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimeLimit_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "分钟";
            // 
            // btnTopShow
            // 
            this.btnTopShow.Location = new System.Drawing.Point(25, 7);
            this.btnTopShow.Name = "btnTopShow";
            this.btnTopShow.Size = new System.Drawing.Size(75, 23);
            this.btnTopShow.TabIndex = 8;
            this.btnTopShow.Text = "置顶显示";
            this.btnTopShow.UseVisualStyleBackColor = true;
            this.btnTopShow.Click += new System.EventHandler(this.btnTopShow_Click);
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}