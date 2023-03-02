﻿using System;
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
            }
        }
    }
}