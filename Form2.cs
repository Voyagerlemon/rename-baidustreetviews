using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static rename_baidustreetviews.Form1;
using System.Collections;
using System.Runtime.InteropServices;

namespace rename_baidustreetviews
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public class FileNameSort : IComparer
        {
            //调用windos 的 DLL
            [System.Runtime.InteropServices.DllImport("Shlwapi.dll", CharSet = CharSet.Unicode)]
            private static extern int StrCmpLogicalW(string param1, string param2);

            //前后文件名进行比较。
            public int Compare(object name1, object name2)
            {
                if (null == name1 && null == name2)
                {
                    return 0;
                }
                if (null == name1)
                {
                    return -1;
                }
                if (null == name2)
                {
                    return 1;
                }
                return StrCmpLogicalW(name1.ToString(), name2.ToString());
            }
        }
        private void btnChoseFolder_Click(object sender, EventArgs e)
        {
            FolderSelectDialog dialog = new FolderSelectDialog();
            if (dialog.ShowDialog(this.Handle))
            {
                FolderPath.Text = dialog.FileName;
                DirectoryInfo directoryInfo = new DirectoryInfo(FolderPath.Text);
                FileInfo[] fileInfos = directoryInfo.GetFiles();
                Array.Sort(fileInfos, new FileNameSort());
            }
        }

        private void btnChoseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "请选择文件";
            dialog.Filter = "文本文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FilePath.Text = dialog.FileName;
            }
        }

        private void btnRenaming_Click(object sender, EventArgs e)
        {
            if (FolderPath.Text == "" && FilePath.Text == "" || FolderPath.Text == "" || FilePath.Text == "")
            {
                MessageBox.Show("请选择文件夹或txt文件路径", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            else if (textBoxPrefix.Text == "")
            {
                MessageBox.Show("必须设置前缀，是城市名，如：beijing", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            DateTime startTime = DateTime.Now;

            string[] fileInfos = Directory.GetFiles(FolderPath.Text);
            Array.Sort(fileInfos, new FileNameSort());
            string[] TextLines = File.ReadAllLines(FilePath.Text);
            for (int i = 0; i < TextLines.Length; i++)
            {
                string strLineText = TextLines[i];
                string filePrefix = textBoxPrefix.Text.Trim();
                List<string> listLng = new List<string>(strLineText.Split(','));
                char[] charArr = listLng[2].ToCharArray();

                StringBuilder sb = new StringBuilder();
                foreach (char c in charArr)
                {
                    if (c == '"')
                    {
                        sb.Append(",");
                    }
                    else
                    {
                        sb.Append(c);
                    }
                }
                string singleFileName = sb.ToString();
                List<string> listLat = new List<string>(singleFileName.Split(','));
             
                string fileName = filePrefix + "_" + listLng[1] + "_" + listLat[0] + ".png";
                string newFilesPath = FolderPath.Text + "\\" + fileName;
                var path2 = newFilesPath.Replace('\\', '/');
                string newFolderPath = "E:\\StreetView\\BaiduPanoramas\\worked_panoramas\\working";
                if (!Directory.Exists(newFolderPath))
                {
                    Directory.CreateDirectory(newFolderPath);
                }
                try
                {

                    File.Move(fileInfos[i], Path.Combine(newFolderPath, fileName));
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            DateTime endTime = DateTime.Now;
            TimeSpan timeSpan = endTime - startTime;
            string timeConsuming = timeSpan.Hours.ToString() + "时" + timeSpan.Minutes.ToString() + "分" + timeSpan.Seconds.ToString() + "秒" + timeSpan.Milliseconds.ToString() + "毫秒";
            MessageBox.Show("文件重命名完成，总耗时：" + timeConsuming, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
