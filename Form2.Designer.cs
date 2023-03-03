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
            this.btnChoseFolder = new System.Windows.Forms.Button();
            this.btnChoseFile = new System.Windows.Forms.Button();
            this.FolderPath = new System.Windows.Forms.TextBox();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.labelText = new System.Windows.Forms.Label();
            this.textBoxPrefix = new System.Windows.Forms.TextBox();
            this.btnRenaming = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChoseFolder
            // 
            this.btnChoseFolder.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChoseFolder.Location = new System.Drawing.Point(13, 13);
            this.btnChoseFolder.Name = "btnChoseFolder";
            this.btnChoseFolder.Size = new System.Drawing.Size(119, 33);
            this.btnChoseFolder.TabIndex = 0;
            this.btnChoseFolder.Text = "选择重命名文件夹";
            this.btnChoseFolder.UseVisualStyleBackColor = true;
            this.btnChoseFolder.Click += new System.EventHandler(this.btnChoseFolder_Click);
            // 
            // btnChoseFile
            // 
            this.btnChoseFile.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChoseFile.Location = new System.Drawing.Point(13, 63);
            this.btnChoseFile.Name = "btnChoseFile";
            this.btnChoseFile.Size = new System.Drawing.Size(119, 33);
            this.btnChoseFile.TabIndex = 1;
            this.btnChoseFile.Text = "选择txt文件";
            this.btnChoseFile.UseVisualStyleBackColor = true;
            this.btnChoseFile.Click += new System.EventHandler(this.btnChoseFile_Click);
            // 
            // FolderPath
            // 
            this.FolderPath.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FolderPath.Location = new System.Drawing.Point(153, 13);
            this.FolderPath.Multiline = true;
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.Size = new System.Drawing.Size(464, 28);
            this.FolderPath.TabIndex = 2;
            // 
            // FilePath
            // 
            this.FilePath.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FilePath.Location = new System.Drawing.Point(153, 68);
            this.FilePath.Multiline = true;
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(464, 28);
            this.FilePath.TabIndex = 3;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelText.Location = new System.Drawing.Point(12, 123);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(65, 20);
            this.labelText.TabIndex = 4;
            this.labelText.Text = "文件前缀";
            // 
            // textBoxPrefix
            // 
            this.textBoxPrefix.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPrefix.Location = new System.Drawing.Point(83, 120);
            this.textBoxPrefix.Multiline = true;
            this.textBoxPrefix.Name = "textBoxPrefix";
            this.textBoxPrefix.Size = new System.Drawing.Size(161, 29);
            this.textBoxPrefix.TabIndex = 5;
            // 
            // btnRenaming
            // 
            this.btnRenaming.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRenaming.Location = new System.Drawing.Point(283, 120);
            this.btnRenaming.Name = "btnRenaming";
            this.btnRenaming.Size = new System.Drawing.Size(148, 32);
            this.btnRenaming.TabIndex = 6;
            this.btnRenaming.Text = "开始重命名";
            this.btnRenaming.UseVisualStyleBackColor = true;
            this.btnRenaming.Click += new System.EventHandler(this.btnRenaming_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 175);
            this.Controls.Add(this.btnRenaming);
            this.Controls.Add(this.textBoxPrefix);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.FilePath);
            this.Controls.Add(this.FolderPath);
            this.Controls.Add(this.btnChoseFile);
            this.Controls.Add(this.btnChoseFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoseFolder;
        private System.Windows.Forms.Button btnChoseFile;
        private System.Windows.Forms.TextBox FolderPath;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.TextBox textBoxPrefix;
        private System.Windows.Forms.Button btnRenaming;
    }
}