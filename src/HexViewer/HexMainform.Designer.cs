namespace HexViewer
{
    partial class HexMainform
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Select_file = new System.Windows.Forms.Button();
            this.tb_filepath = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_CopyHex = new System.Windows.Forms.Button();
            this.btn_SelectHex = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Select_file);
            this.groupBox1.Controls.Add(this.tb_filepath);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btn_Select_file
            // 
            this.btn_Select_file.Location = new System.Drawing.Point(496, 18);
            this.btn_Select_file.Name = "btn_Select_file";
            this.btn_Select_file.Size = new System.Drawing.Size(74, 23);
            this.btn_Select_file.TabIndex = 1;
            this.btn_Select_file.Text = "选择文件";
            this.btn_Select_file.UseVisualStyleBackColor = true;
            this.btn_Select_file.Click += new System.EventHandler(this.btn_Select_file_Click);
            // 
            // tb_filepath
            // 
            this.tb_filepath.Location = new System.Drawing.Point(12, 19);
            this.tb_filepath.Name = "tb_filepath";
            this.tb_filepath.Size = new System.Drawing.Size(479, 21);
            this.tb_filepath.TabIndex = 0;
            this.tb_filepath.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tb_filepath_MouseDoubleClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 69);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(578, 176);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btn_CopyHex
            // 
            this.btn_CopyHex.Location = new System.Drawing.Point(435, 262);
            this.btn_CopyHex.Name = "btn_CopyHex";
            this.btn_CopyHex.Size = new System.Drawing.Size(75, 27);
            this.btn_CopyHex.TabIndex = 2;
            this.btn_CopyHex.Text = "复制Hex";
            this.btn_CopyHex.UseVisualStyleBackColor = true;
            this.btn_CopyHex.Click += new System.EventHandler(this.btn_CopyHex_Click);
            // 
            // btn_SelectHex
            // 
            this.btn_SelectHex.Location = new System.Drawing.Point(516, 262);
            this.btn_SelectHex.Name = "btn_SelectHex";
            this.btn_SelectHex.Size = new System.Drawing.Size(75, 27);
            this.btn_SelectHex.TabIndex = 2;
            this.btn_SelectHex.Text = "选中Hex";
            this.btn_SelectHex.UseVisualStyleBackColor = true;
            this.btn_SelectHex.Click += new System.EventHandler(this.btn_SelectHex_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(82, 273);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(347, 12);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "source code link （https://github.com/oceanho/HexViewer）";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // HexMainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 302);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_SelectHex);
            this.Controls.Add(this.btn_CopyHex);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "HexMainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Hex String Viewer（.NET）";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_filepath;
        private System.Windows.Forms.Button btn_Select_file;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_CopyHex;
        private System.Windows.Forms.Button btn_SelectHex;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

