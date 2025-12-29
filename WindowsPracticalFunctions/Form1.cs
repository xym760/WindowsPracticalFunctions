using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsPracticalFunctions
{
    public partial class Form1 : Form
    {
        ArrayList willModifyFilePathList = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            fileExtensionComboBox.Items.Add("jpg");
            fileExtensionComboBox.Items.Add("mp4");
            fileExtensionComboBox.Items.Add("mp3");
            fileExtensionComboBox.Items.Add("png");
            fileExtensionComboBox.Items.Add("avi");
            fileExtensionComboBox.SelectedIndex = 0;
        }

        private void ChooseFolderButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.folderBrowserDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string folderPath = this.folderBrowserDialog1.SelectedPath;
                string[] filePaths = Directory.GetFiles(folderPath);
                int fileCount = 0;
                string dragFileText = "";
                willModifyFilePathList.Clear();
                foreach (string filePath in filePaths)
                {
                    if (!IsFile(filePath))
                    {
                        continue;
                    }
                    willModifyFilePathList.Add(filePath);
                    fileCount++;
                    if (fileCount > 1)
                    {
                        dragFileText = dragFileText + filePath.Substring(filePath.LastIndexOf("\\") + 1) + "\r\n";
                    }
                    else
                    {
                        dragFileText = filePath.Substring(filePath.LastIndexOf("\\") + 1) + "\r\n";
                    };
                }
                this.folderPathTextBox.Text = dragFileText + "将修改" + fileCount + "个文件";
            }
        }

        private void FolderPathTextBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            string dragFileText = "";
            int fileCount = 0;
            willModifyFilePathList.Clear();
            foreach (var filePath in filePaths)
            {
                if (!IsFile(filePath))
                {
                    continue;
                }
                willModifyFilePathList.Add(filePath);
                fileCount++;
                if (fileCount > 1)
                {
                    dragFileText = dragFileText + filePath.Substring(filePath.LastIndexOf("\\") + 1) + "\r\n";
                }
                else
                {
                    dragFileText = filePath.Substring(filePath.LastIndexOf("\\") + 1) + "\r\n";
                }

            }
            this.folderPathTextBox.Text = dragFileText + "将修改" + fileCount + "个文件";
        }


        /**
         * 是否为一个文件.
         */
        private bool IsFile(string filePath)
        {
            bool result = File.GetAttributes(filePath).HasFlag(FileAttributes.Directory);
            return !result;
        }

        private void folderPathTextBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void folderPathTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            ArrayList newFilePathList = new ArrayList();
            DialogResult dr = MessageBox.Show("确定要修改吗？", "修改扩展名", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string newExtension = "." + this.fileExtensionComboBox.Text;
                bool appendingSuffix = this.appendingSuffixCheckBox.Checked;

                foreach (string filePath in willModifyFilePathList)
                {
                    string oldExtension = Path.GetExtension(filePath);
                    string newFilePath;
                    if (appendingSuffix)
                    {
                        newFilePath = filePath + newExtension;
                    }
                    else
                    {
                        newFilePath = filePath.Substring(0, filePath.Length - oldExtension.Length) + newExtension;
                    }
                    int a =newFilePath.Length;
                    if (newFilePath.Length > 2)
                    {
                        
                    }
                    File.Move(filePath, newFilePath);
                    newFilePathList.Add(newFilePath);
                }
                willModifyFilePathList = newFilePathList;
            }
        }

        private void appendingSuffix_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerateIco_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap b = new Bitmap(ofd.FileName);
                string oldExtension = Path.GetExtension(ofd.FileName);
                string newFilePath = ofd.FileName.Substring(0, ofd.FileName.Length - oldExtension.Length) + ".ico";
                CreateIcon(b, newFilePath);
            }
        }

        /**
         * 将图片转换为ico格式.
         */
        void CreateIcon(Bitmap bmp, string path)
        {
            Bitmap bm = new Bitmap(bmp, new Size(64, 64));
            Icon icon = Icon.FromHandle(bm.GetHicon());
            System.IO.Stream stream = new System.IO.FileStream(path, System.IO.FileMode.OpenOrCreate);
            icon.Save(stream);
            stream.Close();
            MessageBox.Show("创建成功，生成的ico图标在" + path);
        }

        private void btnTopShow_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
            Button clickedButton = sender as Button;

            if (this.TopMost)
            {
                clickedButton.BackColor = System.Drawing.Color.Gray;
            }
            else
            {
                clickedButton.BackColor = System.Drawing.SystemColors.Control;
            }
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            // 实例化新窗体 TimerForm
            TimerForm timerForm = new TimerForm();
            // 显示新窗体（非模态窗口，可同时操作主窗体和新窗体）
            timerForm.Show();
        }

        private void fileExtensionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
