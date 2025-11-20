using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsPracticalFunctions
{
    public partial class TimerForm : Form
    {
        // 累计经过的毫秒数（核心变量）
        private int _elapsedMilliseconds = 0;
        // 计时器是否运行中（可选，用于防重复点击）
        private bool _isRunning = false;
        // 是否处于暂停状态
        private bool _isPaused = false;

        public TimerForm()
        {
            InitializeComponent();
            comboBoxTimeLimit.Items.Add("5");
            comboBoxTimeLimit.Items.Add("15");
            comboBoxTimeLimit.Items.Add("25");
            comboBoxTimeLimit.Items.Add("30");
            comboBoxTimeLimit.Items.Add("60");
            comboBoxTimeLimit.SelectedIndex = 0;
        }

        private void timerComponent_Tick(object sender, EventArgs e)
        {
            if (!_isPaused) // 仅在非暂停状态下累计时间
            {
                _elapsedMilliseconds += timerComponent.Interval; // 累加间隔时长（100毫秒）
                labelTime.Text = FormatTime(_elapsedMilliseconds); // 实时更新显示
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_isRunning && !_isPaused) return; // 已在运行且未暂停，不重复启动

            _elapsedMilliseconds = 0; // 重置累计时间
            _isRunning = true;
            _isPaused = false;
            // 启动计时器
            timerComponent.Start();
            labelTime.Text = "00:00:00"; // 清空显示

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (!_isRunning) return; // 未开始计时，不响应

            if (_isPaused)
            {
                // 继续计时：重启 Timer
                timerComponent.Start();
                _isPaused = false;
                btnPause.Text = "暂停";
            }
            else
            {
                // 暂停计时：停止 Timer
                timerComponent.Stop();
                _isPaused = true;
                btnPause.Text = "继续";
            }
        }

        // 辅助方法：毫秒数转“时:分:秒”格式
        private string FormatTime(int totalMilliseconds)
        {
            int totalSeconds = totalMilliseconds / 1000;
            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;
            return $"{hours:D2}:{minutes:D2}:{seconds:D2}"; // 两位数格式化（如 01:05:09）
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (!_isRunning) return; // 未开始计时，不响应

            // 1. 记录当前累计时间（格式化后添加到列表）
            string currentTime = FormatTime(_elapsedMilliseconds);
            var item = listViewRecords.Items.Add($"记录 {listViewRecords.Items.Count + 1}：{currentTime}");
            int totalSeconds = _elapsedMilliseconds / 1000;
            int limitSeconds = int.Parse(this.comboBoxTimeLimit.Text) * 60;
            if (totalSeconds > limitSeconds)
            {
                item.ForeColor = Color.Red; // 直接设置该项文本颜色
            }
            else
            {
                item.ForeColor = Color.Green;
            }


            // 2. 重置累计时间，从头开始计时（保持 Timer 运行，不暂停）
            _elapsedMilliseconds = 0;
            labelTime.Text = "00:00:00"; // 重置显示
        }

        private void comboBoxTimeLimit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewRecords_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTopShow_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
            System.Windows.Forms.Button clickedButton = sender as System.Windows.Forms.Button;

            if (this.TopMost)
            {
                clickedButton.BackColor = System.Drawing.Color.Gray;
            }
            else
            {
                clickedButton.BackColor = System.Drawing.SystemColors.Control;
            }
        }
    }
}
