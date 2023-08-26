using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Reflection;

namespace rename_baidustreetviews
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            listBoxFolderFiles.Items.Clear();
            FolderSelectDialog dialog = new FolderSelectDialog();
            if (dialog.ShowDialog(this.Handle))
            {
                FolderPath.Text = dialog.FileName;

                // 遍历文件夹下的文件
                DirectoryInfo directoryInfo = new DirectoryInfo(FolderPath.Text);
                FileInfo[] fileInfos = directoryInfo.GetFiles();
                Array.Sort(fileInfos, new FileNameSort());
                //FileInfo[] sortedFiles = fileInfos.OrderBy(r => r.Name).ToArray();
                foreach (FileInfo fileInfo in fileInfos)
                    listBoxFolderFiles.Items.Add(fileInfo.FullName);
                List<string> tifNames = new List<string>();

                imageList.Images.Clear();
                for (int i = 0; i < fileInfos.Length; i++)//遍历文件夹

                {

                    if (fileInfos[i].Length > 0 && fileInfos[i].Extension == ".png")//或者jpg，png 文件大小要大于0且是图片文件
                    {
                        Image image = Image.FromFile(fileInfos[i].DirectoryName + "\\" + fileInfos[i].Name);    //获取文件                 
                        tifNames.Add(fileInfos[i].Name);//添加文件名
                        imageList.Images.Add(image);//添加图片
                    }

                }
                //初始化设置
                //listViewImage.View = View.LargeIcon;
                listViewImages.Items.Clear();
                listViewImages.LargeImageList = imageList;

                listViewImages.BeginUpdate();
                for (int i = 0; i < tifNames.Count; i++)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.ImageIndex = i;
                    lvi.Text = tifNames[i];
                    listViewImages.Items.Add(lvi);

                }
                listViewImages.EndUpdate();
                MessageBox.Show("图片加载完成", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChoseFile_Click(object sender, EventArgs e)
        {
            listBoxTxt.Items.Clear();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "请选择文件";
            dialog.Filter = "文本文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FilePath.Text = dialog.FileName;
                string[] Textlines = File.ReadAllLines(FilePath.Text);

                foreach (string line in Textlines)
                {
                    listBoxTxt.Items.Add(line);
                }
            }
        }
        private void btnMoveToFolder_Click(object sender, EventArgs e)
        {
            listBoxFolderFiles.Items.Clear();
            FolderSelectDialog dialog = new FolderSelectDialog();
            if (dialog.ShowDialog(this.Handle))
            {
                textBoxNewFolder.Text = dialog.FileName;

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

            //DirectoryInfo directoryinfo = new DirectoryInfo(FolderPath.Text);
            //FileInfo[] fileInfos = directoryinfo.GetFiles();
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
                //string newfileName = listLngLast[0];
                string fileName = filePrefix + "_" + listLng[1] + "_" + listLat[0] + ".png";
                //string oldFilesPath = fileInfos[i].FullName;
                string newFilesPath = FolderPath.Text + "\\" + fileName;
                //var path1 = oldFilesPath.Replace('\\', '/');
                var path2 = newFilesPath.Replace('\\', '/');
                //FileSystem.Rename(oldFilesPath, newFilesPath);
                //string old = fileInfos[i].Name;

                string newFolderPath = "E:\\StreetView\\BaiduPanoramas\\worked_panoramas\\working2";
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

        private void textBoxPrefix_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRenamingTool_Click(object sender, EventArgs e)
        {
            Form2 renamingTool = new Form2();
            renamingTool.ShowDialog();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    //FileSystem.Rename("E:/StreetView/BaiduPanoramas/worked_panoramas/working1/15.png", "E:/StreetView/BaiduPanoramas/worked_panoramas/working1/beijing_116.422654_39.9136867.png");
        //    MessageBox.Show("文件命名测试成功", "成功提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        //}
    }
}
