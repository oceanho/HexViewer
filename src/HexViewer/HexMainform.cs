﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace HexViewer
{
    public partial class HexMainform : Form
    {
        public HexMainform()
        {
            InitializeComponent();
        }

        private void btn_Select_file_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog fileSelectDialog = new OpenFileDialog())
            {
                fileSelectDialog.Multiselect = false;
                fileSelectDialog.CheckFileExists = true;
                                
                fileSelectDialog.FilterIndex = 0;                
                fileSelectDialog.FileOk += fileSelectDialog_FileOk;
                fileSelectDialog.Filter = "(*.dll,*.exe)|*.exe;*.dll|(所有文件)|*.*";
                fileSelectDialog.InitialDirectory = this.tb_filepath.Text.Length < 1 ? AppDomain.CurrentDomain.BaseDirectory : this.tb_filepath.Text;
                fileSelectDialog.ShowDialog();
            }
        }

        void fileSelectDialog_FileOk(object sender, CancelEventArgs e)
        {
            tb_filepath.Text = (sender as OpenFileDialog).FileName;
            GenerateHexString();
        }

        private void GenerateHexString()
        {            
            if (!File.Exists(tb_filepath.Text))
                MessageBox.Show("出大事了", "我干，路径文件不存在", MessageBoxButtons.OK, MessageBoxIcon.Error);
            byte[] bytes = File.ReadAllBytes(tb_filepath.Text);
            StringBuilder hexSb = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
                hexSb.Append(Convert.ToString(bytes[i], 16).ToUpper().PadLeft(2, '0'));
            this.richTextBox1.Text = "0x" + hexSb.ToString();
            bytes = null;
        }

        private void btn_CopyHex_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(this.richTextBox1.Text);
        }

        private void btn_SelectHex_Click(object sender, EventArgs e)
        {
            richTextBox1.Focus();
            richTextBox1.SelectAll();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/oceanho/HexViewer");
        }

        private void tb_filepath_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tb_filepath.Focus();
            tb_filepath.SelectAll();
        }

        private void btn_Gernate_Click(object sender, EventArgs e)
        {
            GenerateHexString();
        }
    }
}
