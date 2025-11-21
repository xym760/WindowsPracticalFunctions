using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        // 累计经过的单次总毫秒数
        private long _elapsedMilliseconds = 0;
        // 累计经过的总毫秒数
        private long _elapsedTotalMilliseconds = 0;
        // 单次耗时的时间起点
        long lastElapsedTotalMilliseconds = 0;
        // 领先的总毫秒数
        private long _aheadTotalMilliseconds = 0;
        // 完成总页数
        private int _totalPages = 0;
        // 计时器是否运行中（可选，用于防重复点击）
        private bool _isRunning = false;
        // 是否处于暂停状态
        private bool _isPaused = false;
        // 高精度计时器
        private Stopwatch stopwatch;

        public TimerForm()
        {
            InitializeComponent();
            comboBoxTimeLimit.Items.Add("5");
            comboBoxTimeLimit.Items.Add("15");
            comboBoxTimeLimit.Items.Add("25");
            comboBoxTimeLimit.Items.Add("30");
            comboBoxTimeLimit.Items.Add("60");
            comboBoxTimeLimit.SelectedIndex = 0;
            comboBoxPages.Items.Add("1");
            comboBoxPages.SelectedIndex = 0;
            // 初始化 Stopwatch
            stopwatch = new Stopwatch();
        }

        private void timerComponent_Tick(object sender, EventArgs e)
        {
            if (!_isPaused) // 仅在非暂停状态下累计时间
            {
                //获取真实流逝时间（毫秒）：从开始计时到现在实际过了多久
                _elapsedTotalMilliseconds = stopwatch.ElapsedMilliseconds;
                // 计算经过的单次总毫秒数
                _elapsedMilliseconds = _elapsedTotalMilliseconds - lastElapsedTotalMilliseconds;

                labelTime.Text = FormatTime(_elapsedMilliseconds); // 实时更新显示
                labelTotalTime.Text = FormatTime(_elapsedTotalMilliseconds);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_isRunning && !_isPaused) return; // 已在运行且未暂停，不重复启动

            _elapsedMilliseconds = 0; // 重置累计时间
            _isRunning = true;
            _isPaused = false;
            // 重置并启动 Stopwatch（记录从此时开始的流逝时间）
            stopwatch.Restart();
            // 启动 Timer（定期校准显示）
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
                // 恢复 Stopwatch（继续计时，不清零）
                stopwatch.Start();
                _isPaused = false;
                btnPause.Text = "暂停";
            }
            else
            {
                // 暂停计时：停止 Timer
                timerComponent.Stop();
                // 暂停 Stopwatch
                stopwatch.Stop();
                _isPaused = true;
                btnPause.Text = "继续";
            }
        }

        // 辅助方法：毫秒数转“时:分:秒”格式
        private string FormatTime(long totalMilliseconds)
        {
            int totalSeconds = (int)(totalMilliseconds / 1000);
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
            long limitMilliseconds = int.Parse(this.comboBoxTimeLimit.Text) * 60 * 1000;
            if (_elapsedMilliseconds > limitMilliseconds)
            {
                item.ForeColor = Color.Red; // 直接设置该项文本颜色
            }
            else
            {
                item.ForeColor = Color.Green;
            }
            // 单次领先秒数
            long aheadMilliseconds = limitMilliseconds - _elapsedMilliseconds;
            // 更新总领先毫秒数
            _aheadTotalMilliseconds += aheadMilliseconds;
            labelAheadTime.Text = FormatTime(_aheadTotalMilliseconds);
            if (_aheadTotalMilliseconds < 0)
            {
                labelAheadTime.ForeColor = Color.Red;
            }
            else
            {
                labelAheadTime.ForeColor = Color.Green;
            }
            // 更新总页数
            _totalPages += int.Parse(this.comboBoxPages.Text);
            labelTotalPages.Text = "共完成" + _totalPages.ToString() + "页";
            // 更新每页多少分钟
            float tempTotalMinutes = _elapsedTotalMilliseconds / 1000f / 60f;
            float averageMinutesPerPage = tempTotalMinutes / _totalPages;
            labelAverageTime.Text = averageMinutesPerPage.ToString() + "分钟/页";

            // 2. 重置累计时间，从头开始计时（保持 Timer 运行，不暂停）
            lastElapsedTotalMilliseconds = _elapsedTotalMilliseconds;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void labelTotalPages_Click(object sender, EventArgs e)
        {

        }

        private void TimerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
