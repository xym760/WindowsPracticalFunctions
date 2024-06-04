using System;
using System.Collections;
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
                    File.Move(filePath, newFilePath);
                    newFilePathList.Add(newFilePath);
                }
                willModifyFilePathList = newFilePathList;
            }
        }

        private void appendingSuffix_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
