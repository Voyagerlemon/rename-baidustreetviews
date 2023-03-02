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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.FolderPath = new System.Windows.Forms.TextBox();
            this.btnChoseFile = new System.Windows.Forms.Button();
            this.btnChoseFolder = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.listViewImages = new System.Windows.Forms.ListView();
            this.listBoxFolderFiles = new System.Windows.Forms.ListBox();
            this.listBoxTxt = new System.Windows.Forms.ListBox();
            this.textBoxPrefix = new System.Windows.Forms.TextBox();
            this.labelText = new System.Windows.Forms.Label();
            this.btnRenaming = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
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
            this.splitter1.Size = new System.Drawing.Size(1192, 128);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(148, 77);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(540, 35);
            this.textBox2.TabIndex = 8;
            // 
            // FolderPath
            // 
            this.FolderPath.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FolderPath.Location = new System.Drawing.Point(148, 13);
            this.FolderPath.Multiline = true;
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.Size = new System.Drawing.Size(540, 33);
            this.FolderPath.TabIndex = 7;
            // 
            // btnChoseFile
            // 
            this.btnChoseFile.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChoseFile.Location = new System.Drawing.Point(13, 79);
            this.btnChoseFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnChoseFile.Name = "btnChoseFile";
            this.btnChoseFile.Size = new System.Drawing.Size(119, 33);
            this.btnChoseFile.TabIndex = 6;
            this.btnChoseFile.Text = "选择txt文件";
            this.btnChoseFile.UseVisualStyleBackColor = true;
            // 
            // btnChoseFolder
            // 
            this.btnChoseFolder.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChoseFolder.Location = new System.Drawing.Point(13, 13);
            this.btnChoseFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnChoseFolder.Name = "btnChoseFolder";
            this.btnChoseFolder.Size = new System.Drawing.Size(119, 33);
            this.btnChoseFolder.TabIndex = 5;
            this.btnChoseFolder.Text = "选择文件夹";
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
            this.splitContainer1.Size = new System.Drawing.Size(1192, 510);
            this.splitContainer1.SplitterDistance = 468;
            this.splitContainer1.TabIndex = 9;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(0, 0);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1192, 38);
            this.progressBar1.TabIndex = 0;
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
            this.splitContainer2.Size = new System.Drawing.Size(1192, 468);
            this.splitContainer2.SplitterDistance = 883;
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
            this.splitContainer3.Size = new System.Drawing.Size(883, 468);
            this.splitContainer3.SplitterDistance = 433;
            this.splitContainer3.TabIndex = 0;
            // 
            // listViewImages
            // 
            this.listViewImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewImages.HideSelection = false;
            this.listViewImages.Location = new System.Drawing.Point(0, 0);
            this.listViewImages.Name = "listViewImages";
            this.listViewImages.Size = new System.Drawing.Size(446, 468);
            this.listViewImages.TabIndex = 0;
            this.listViewImages.UseCompatibleStateImageBehavior = false;
            // 
            // listBoxFolderFiles
            // 
            this.listBoxFolderFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFolderFiles.FormattingEnabled = true;
            this.listBoxFolderFiles.ItemHeight = 17;
            this.listBoxFolderFiles.Location = new System.Drawing.Point(0, 0);
            this.listBoxFolderFiles.Name = "listBoxFolderFiles";
            this.listBoxFolderFiles.Size = new System.Drawing.Size(433, 468);
            this.listBoxFolderFiles.TabIndex = 0;
            // 
            // listBoxTxt
            // 
            this.listBoxTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTxt.FormattingEnabled = true;
            this.listBoxTxt.ItemHeight = 17;
            this.listBoxTxt.Location = new System.Drawing.Point(0, 0);
            this.listBoxTxt.Name = "listBoxTxt";
            this.listBoxTxt.Size = new System.Drawing.Size(305, 468);
            this.listBoxTxt.TabIndex = 0;
            // 
            // textBoxPrefix
            // 
            this.textBoxPrefix.Location = new System.Drawing.Point(799, 19);
            this.textBoxPrefix.Name = "textBoxPrefix";
            this.textBoxPrefix.Size = new System.Drawing.Size(151, 23);
            this.textBoxPrefix.TabIndex = 10;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelText.Location = new System.Drawing.Point(713, 19);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(65, 20);
            this.labelText.TabIndex = 11;
            this.labelText.Text = "文件前缀";
            // 
            // btnRenaming
            // 
            this.btnRenaming.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRenaming.Location = new System.Drawing.Point(717, 77);
            this.btnRenaming.Margin = new System.Windows.Forms.Padding(4);
            this.btnRenaming.Name = "btnRenaming";
            this.btnRenaming.Size = new System.Drawing.Size(166, 33);
            this.btnRenaming.TabIndex = 5;
            this.btnRenaming.Text = "开始重命名";
            this.btnRenaming.UseVisualStyleBackColor = true;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 638);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.textBoxPrefix);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.FolderPath);
            this.Controls.Add(this.btnChoseFile);
            this.Controls.Add(this.btnRenaming);
            this.Controls.Add(this.btnChoseFolder);
            this.Controls.Add(this.splitter1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox textBox2;
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
    }
}

