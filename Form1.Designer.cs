namespace rename_baidustreetviews
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.FolderPath = new System.Windows.Forms.TextBox();
            this.btnChoseFile = new System.Windows.Forms.Button();
            this.btnChoseFolder = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.listBoxFolderFiles = new System.Windows.Forms.ListBox();
            this.listViewImages = new System.Windows.Forms.ListView();
            this.listBoxTxt = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBoxPrefix = new System.Windows.Forms.TextBox();
            this.labelText = new System.Windows.Forms.Label();
            this.btnRenaming = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnMoveToFolder = new System.Windows.Forms.Button();
            this.textBoxNewFolder = new System.Windows.Forms.TextBox();
            this.btnRenamingTool = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1304, 128);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // FilePath
            // 
            this.FilePath.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FilePath.Location = new System.Drawing.Point(199, 68);
            this.FilePath.Multiline = true;
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(464, 35);
            this.FilePath.TabIndex = 8;
            // this.FilePath.TextChanged += new System.EventHandler(this.FilePath_TextChanged);
            // 
            // FolderPath
            // 
            this.FolderPath.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FolderPath.Location = new System.Drawing.Point(199, 11);
            this.FolderPath.Multiline = true;
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.Size = new System.Drawing.Size(464, 33);
            this.FolderPath.TabIndex = 7;
            // 
            // btnChoseFile
            // 
            this.btnChoseFile.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChoseFile.Location = new System.Drawing.Point(13, 66);
            this.btnChoseFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnChoseFile.Name = "btnChoseFile";
            this.btnChoseFile.Size = new System.Drawing.Size(160, 38);
            this.btnChoseFile.TabIndex = 6;
            this.btnChoseFile.Text = "选择txt文件";
            this.btnChoseFile.UseVisualStyleBackColor = true;
            this.btnChoseFile.Click += new System.EventHandler(this.btnChoseFile_Click);
            // 
            // btnChoseFolder
            // 
            this.btnChoseFolder.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChoseFolder.Location = new System.Drawing.Point(13, 7);
            this.btnChoseFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnChoseFolder.Name = "btnChoseFolder";
            this.btnChoseFolder.Size = new System.Drawing.Size(160, 45);
            this.btnChoseFolder.TabIndex = 5;
            this.btnChoseFolder.Text = "重命名文件夹";
            this.btnChoseFolder.UseVisualStyleBackColor = true;
            this.btnChoseFolder.Click += new System.EventHandler(this.btnChoseFolder_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 128);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.progressBar1);
            this.splitContainer1.Size = new System.Drawing.Size(1304, 510);
            this.splitContainer1.SplitterDistance = 481;
            this.splitContainer1.TabIndex = 9;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.listBoxTxt);
            this.splitContainer2.Size = new System.Drawing.Size(1304, 481);
            this.splitContainer2.SplitterDistance = 965;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.listBoxFolderFiles);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.listViewImages);
            this.splitContainer3.Size = new System.Drawing.Size(965, 481);
            this.splitContainer3.SplitterDistance = 473;
            this.splitContainer3.TabIndex = 0;
            // 
            // listBoxFolderFiles
            // 
            this.listBoxFolderFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFolderFiles.FormattingEnabled = true;
            this.listBoxFolderFiles.ItemHeight = 24;
            this.listBoxFolderFiles.Location = new System.Drawing.Point(0, 0);
            this.listBoxFolderFiles.Name = "listBoxFolderFiles";
            this.listBoxFolderFiles.Size = new System.Drawing.Size(473, 481);
            this.listBoxFolderFiles.TabIndex = 0;
            // 
            // listViewImages
            // 
            this.listViewImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewImages.HideSelection = false;
            this.listViewImages.Location = new System.Drawing.Point(0, 0);
            this.listViewImages.Name = "listViewImages";
            this.listViewImages.Size = new System.Drawing.Size(488, 481);
            this.listViewImages.TabIndex = 0;
            this.listViewImages.UseCompatibleStateImageBehavior = false;
            // 
            // listBoxTxt
            // 
            this.listBoxTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTxt.FormattingEnabled = true;
            this.listBoxTxt.ItemHeight = 24;
            this.listBoxTxt.Location = new System.Drawing.Point(0, 0);
            this.listBoxTxt.Name = "listBoxTxt";
            this.listBoxTxt.Size = new System.Drawing.Size(335, 481);
            this.listBoxTxt.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(750, 25);
            this.progressBar1.TabIndex = 0;
            // 
            // textBoxPrefix
            // 
            this.textBoxPrefix.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPrefix.Location = new System.Drawing.Point(766, 70);
            this.textBoxPrefix.Multiline = true;
            this.textBoxPrefix.Name = "textBoxPrefix";
            this.textBoxPrefix.Size = new System.Drawing.Size(174, 33);
            this.textBoxPrefix.TabIndex = 10;
            this.textBoxPrefix.TextChanged += new System.EventHandler(this.textBoxPrefix_TextChanged);
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelText.Location = new System.Drawing.Point(664, 75);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(96, 28);
            this.labelText.TabIndex = 11;
            this.labelText.Text = "文件前缀";
            // 
            // btnRenaming
            // 
            this.btnRenaming.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRenaming.Location = new System.Drawing.Point(947, 65);
            this.btnRenaming.Margin = new System.Windows.Forms.Padding(4);
            this.btnRenaming.Name = "btnRenaming";
            this.btnRenaming.Size = new System.Drawing.Size(155, 38);
            this.btnRenaming.TabIndex = 5;
            this.btnRenaming.Text = "开始重命名";
            this.btnRenaming.UseVisualStyleBackColor = true;
            this.btnRenaming.Click += new System.EventHandler(this.btnRenaming_Click);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnMoveToFolder
            // 
            this.btnMoveToFolder.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMoveToFolder.Location = new System.Drawing.Point(669, 6);
            this.btnMoveToFolder.Name = "btnMoveToFolder";
            this.btnMoveToFolder.Size = new System.Drawing.Size(206, 46);
            this.btnMoveToFolder.TabIndex = 12;
            this.btnMoveToFolder.Text = "选择保存的文件夹";
            this.btnMoveToFolder.UseVisualStyleBackColor = true;
            this.btnMoveToFolder.Click += new System.EventHandler(this.btnMoveToFolder_Click);
            // 
            // textBoxNewFolder
            // 
            this.textBoxNewFolder.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxNewFolder.Location = new System.Drawing.Point(885, 12);
            this.textBoxNewFolder.Multiline = true;
            this.textBoxNewFolder.Name = "textBoxNewFolder";
            this.textBoxNewFolder.Size = new System.Drawing.Size(407, 32);
            this.textBoxNewFolder.TabIndex = 13;
            // 
            // btnRenamingTool
            // 
            this.btnRenamingTool.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRenamingTool.Location = new System.Drawing.Point(1118, 65);
            this.btnRenamingTool.Name = "btnRenamingTool";
            this.btnRenamingTool.Size = new System.Drawing.Size(174, 33);
            this.btnRenamingTool.TabIndex = 14;
            this.btnRenamingTool.Text = "重命名小插件";
            this.btnRenamingTool.UseVisualStyleBackColor = true;
            this.btnRenamingTool.Click += new System.EventHandler(this.btnRenamingTool_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 638);
            this.Controls.Add(this.btnRenamingTool);
            this.Controls.Add(this.textBoxNewFolder);
            this.Controls.Add(this.btnMoveToFolder);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.textBoxPrefix);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.FolderPath);
            this.Controls.Add(this.btnChoseFile);
            this.Controls.Add(this.btnRenaming);
            this.Controls.Add(this.btnChoseFolder);
            this.Controls.Add(this.splitter1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "百度静态图重命名";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.TextBox FolderPath;
        private System.Windows.Forms.Button btnChoseFile;
        private System.Windows.Forms.Button btnChoseFolder;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.ListBox listBoxFolderFiles;
        private System.Windows.Forms.ListView listViewImages;
        private System.Windows.Forms.ListBox listBoxTxt;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBoxPrefix;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Button btnRenaming;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button btnMoveToFolder;
        private System.Windows.Forms.TextBox textBoxNewFolder;
        private System.Windows.Forms.Button btnRenamingTool;
    }
}

