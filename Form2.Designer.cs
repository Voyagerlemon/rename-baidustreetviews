namespace rename_baidustreetviews
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnRenaming = new System.Windows.Forms.Button();
            this.textBoxPrefix = new System.Windows.Forms.TextBox();
            this.labelText = new System.Windows.Forms.Label();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.FolderPath = new System.Windows.Forms.TextBox();
            this.btnChoseFile = new System.Windows.Forms.Button();
            this.btnChoseFolder = new System.Windows.Forms.Button();
            this.listBoxImagesPath = new System.Windows.Forms.ListBox();
            this.btnOrdering = new System.Windows.Forms.Button();
            this.btnSaveFolder = new System.Windows.Forms.Button();
            this.newFolderPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1088, 305);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // btnRenaming
            // 
            this.btnRenaming.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRenaming.Location = new System.Drawing.Point(411, 238);
            this.btnRenaming.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRenaming.Name = "btnRenaming";
            this.btnRenaming.Size = new System.Drawing.Size(222, 48);
            this.btnRenaming.TabIndex = 14;
            this.btnRenaming.Text = "开始重命名";
            this.btnRenaming.UseVisualStyleBackColor = true;
            this.btnRenaming.Click += new System.EventHandler(this.btnRenaming_Click);
            // 
            // textBoxPrefix
            // 
            this.textBoxPrefix.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPrefix.Location = new System.Drawing.Point(147, 242);
            this.textBoxPrefix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPrefix.Multiline = true;
            this.textBoxPrefix.Name = "textBoxPrefix";
            this.textBoxPrefix.Size = new System.Drawing.Size(240, 42);
            this.textBoxPrefix.TabIndex = 13;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelText.Location = new System.Drawing.Point(41, 247);
            this.labelText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(96, 28);
            this.labelText.TabIndex = 12;
            this.labelText.Text = "文件前缀";
            // 
            // FilePath
            // 
            this.FilePath.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FilePath.Location = new System.Drawing.Point(242, 100);
            this.FilePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FilePath.Multiline = true;
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(694, 40);
            this.FilePath.TabIndex = 11;
            // 
            // FolderPath
            // 
            this.FolderPath.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FolderPath.Location = new System.Drawing.Point(242, 18);
            this.FolderPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FolderPath.Multiline = true;
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.Size = new System.Drawing.Size(694, 40);
            this.FolderPath.TabIndex = 10;
            // 
            // btnChoseFile
            // 
            this.btnChoseFile.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChoseFile.Location = new System.Drawing.Point(32, 93);
            this.btnChoseFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChoseFile.Name = "btnChoseFile";
            this.btnChoseFile.Size = new System.Drawing.Size(178, 50);
            this.btnChoseFile.TabIndex = 9;
            this.btnChoseFile.Text = "选择txt文件";
            this.btnChoseFile.UseVisualStyleBackColor = true;
            this.btnChoseFile.Click += new System.EventHandler(this.btnChoseFile_Click);
            // 
            // btnChoseFolder
            // 
            this.btnChoseFolder.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChoseFolder.Location = new System.Drawing.Point(32, 18);
            this.btnChoseFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChoseFolder.Name = "btnChoseFolder";
            this.btnChoseFolder.Size = new System.Drawing.Size(178, 50);
            this.btnChoseFolder.TabIndex = 8;
            this.btnChoseFolder.Text = "重命名文件夹";
            this.btnChoseFolder.UseVisualStyleBackColor = true;
            this.btnChoseFolder.Click += new System.EventHandler(this.btnChoseFolder_Click);
            // 
            // listBoxImagesPath
            // 
            this.listBoxImagesPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxImagesPath.FormattingEnabled = true;
            this.listBoxImagesPath.ItemHeight = 18;
            this.listBoxImagesPath.Location = new System.Drawing.Point(0, 305);
            this.listBoxImagesPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxImagesPath.Name = "listBoxImagesPath";
            this.listBoxImagesPath.Size = new System.Drawing.Size(1088, 428);
            this.listBoxImagesPath.TabIndex = 15;
            // 
            // btnOrdering
            // 
            this.btnOrdering.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOrdering.Location = new System.Drawing.Point(681, 238);
            this.btnOrdering.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrdering.Name = "btnOrdering";
            this.btnOrdering.Size = new System.Drawing.Size(222, 48);
            this.btnOrdering.TabIndex = 16;
            this.btnOrdering.Text = "开始排序";
            this.btnOrdering.UseVisualStyleBackColor = true;
            this.btnOrdering.Click += new System.EventHandler(this.btnOrdering_Click);
            // 
            // btnSaveFolder
            // 
            this.btnSaveFolder.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveFolder.Location = new System.Drawing.Point(32, 165);
            this.btnSaveFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveFolder.Name = "btnSaveFolder";
            this.btnSaveFolder.Size = new System.Drawing.Size(178, 50);
            this.btnSaveFolder.TabIndex = 17;
            this.btnSaveFolder.Text = "保存至新文件夹";
            this.btnSaveFolder.UseVisualStyleBackColor = true;
            this.btnSaveFolder.Click += new System.EventHandler(this.btnSaveFolder_Click);
            // 
            // newFolderPath
            // 
            this.newFolderPath.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.newFolderPath.Location = new System.Drawing.Point(242, 173);
            this.newFolderPath.Margin = new System.Windows.Forms.Padding(4);
            this.newFolderPath.Multiline = true;
            this.newFolderPath.Name = "newFolderPath";
            this.newFolderPath.Size = new System.Drawing.Size(694, 40);
            this.newFolderPath.TabIndex = 18;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 733);
            this.Controls.Add(this.newFolderPath);
            this.Controls.Add(this.btnSaveFolder);
            this.Controls.Add(this.btnOrdering);
            this.Controls.Add(this.listBoxImagesPath);
            this.Controls.Add(this.btnRenaming);
            this.Controls.Add(this.textBoxPrefix);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.FolderPath);
            this.Controls.Add(this.btnChoseFile);
            this.Controls.Add(this.btnChoseFolder);
            this.Controls.Add(this.splitter1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "命名小插件";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnRenaming;
        private System.Windows.Forms.TextBox textBoxPrefix;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.TextBox FolderPath;
        private System.Windows.Forms.Button btnChoseFile;
        private System.Windows.Forms.Button btnChoseFolder;
        private System.Windows.Forms.ListBox listBoxImagesPath;
        private System.Windows.Forms.Button btnOrdering;
        private System.Windows.Forms.Button btnSaveFolder;
        private System.Windows.Forms.TextBox newFolderPath;
    }
}