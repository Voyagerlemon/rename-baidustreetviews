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
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(655, 165);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // btnRenaming
            // 
            this.btnRenaming.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRenaming.Location = new System.Drawing.Point(267, 116);
            this.btnRenaming.Name = "btnRenaming";
            this.btnRenaming.Size = new System.Drawing.Size(148, 32);
            this.btnRenaming.TabIndex = 14;
            this.btnRenaming.Text = "开始重命名";
            this.btnRenaming.UseVisualStyleBackColor = true;
            // 
            // textBoxPrefix
            // 
            this.textBoxPrefix.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPrefix.Location = new System.Drawing.Point(91, 119);
            this.textBoxPrefix.Multiline = true;
            this.textBoxPrefix.Name = "textBoxPrefix";
            this.textBoxPrefix.Size = new System.Drawing.Size(161, 29);
            this.textBoxPrefix.TabIndex = 13;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelText.Location = new System.Drawing.Point(20, 122);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(65, 20);
            this.labelText.TabIndex = 12;
            this.labelText.Text = "文件前缀";
            // 
            // FilePath
            // 
            this.FilePath.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FilePath.Location = new System.Drawing.Point(161, 67);
            this.FilePath.Multiline = true;
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(464, 28);
            this.FilePath.TabIndex = 11;
            // 
            // FolderPath
            // 
            this.FolderPath.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FolderPath.Location = new System.Drawing.Point(161, 12);
            this.FolderPath.Multiline = true;
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.Size = new System.Drawing.Size(464, 28);
            this.FolderPath.TabIndex = 10;
            // 
            // btnChoseFile
            // 
            this.btnChoseFile.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChoseFile.Location = new System.Drawing.Point(21, 62);
            this.btnChoseFile.Name = "btnChoseFile";
            this.btnChoseFile.Size = new System.Drawing.Size(119, 33);
            this.btnChoseFile.TabIndex = 9;
            this.btnChoseFile.Text = "选择txt文件";
            this.btnChoseFile.UseVisualStyleBackColor = true;
            this.btnChoseFile.Click += new System.EventHandler(this.btnChoseFile_Click);
            // 
            // btnChoseFolder
            // 
            this.btnChoseFolder.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChoseFolder.Location = new System.Drawing.Point(21, 12);
            this.btnChoseFolder.Name = "btnChoseFolder";
            this.btnChoseFolder.Size = new System.Drawing.Size(119, 33);
            this.btnChoseFolder.TabIndex = 8;
            this.btnChoseFolder.Text = "重命名文件夹";
            this.btnChoseFolder.UseVisualStyleBackColor = true;
            this.btnChoseFolder.Click += new System.EventHandler(this.btnChoseFolder_Click);
            // 
            // listBoxImagesPath
            // 
            this.listBoxImagesPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxImagesPath.FormattingEnabled = true;
            this.listBoxImagesPath.ItemHeight = 12;
            this.listBoxImagesPath.Location = new System.Drawing.Point(0, 165);
            this.listBoxImagesPath.Name = "listBoxImagesPath";
            this.listBoxImagesPath.Size = new System.Drawing.Size(655, 262);
            this.listBoxImagesPath.TabIndex = 15;
            // 
            // btnOrdering
            // 
            this.btnOrdering.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOrdering.Location = new System.Drawing.Point(447, 116);
            this.btnOrdering.Name = "btnOrdering";
            this.btnOrdering.Size = new System.Drawing.Size(148, 32);
            this.btnOrdering.TabIndex = 16;
            this.btnOrdering.Text = "开始排序";
            this.btnOrdering.UseVisualStyleBackColor = true;
            this.btnOrdering.Click += new System.EventHandler(this.btnOrdering_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 427);
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
    }
}