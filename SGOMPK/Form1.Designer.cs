﻿namespace SGOMPK
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtmpkcopy = new System.Windows.Forms.TextBox();
            this.header = new System.Windows.Forms.CheckBox();
            this.compressbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTextRe = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameRe = new System.Windows.Forms.TextBox();
            this.btnRePack = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDirectorySaveRe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDirectoryDataRe = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnUnPack = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTextUn = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDirectorySaveUn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txtDirectoryDataUn = new System.Windows.Forms.TextBox();
            this.listfiles = new System.Windows.Forms.Button();
            this.listboxfiles = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(20, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(505, 308);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.txtmpkcopy);
            this.tabPage1.Controls.Add(this.header);
            this.tabPage1.Controls.Add(this.compressbox);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lbTextRe);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtNameRe);
            this.tabPage1.Controls.Add(this.btnRePack);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtDirectorySaveRe);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtDirectoryDataRe);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(497, 282);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "RePack";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "MPK File to copy:";
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(412, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 26;
            this.button3.Text = "Open";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtmpkcopy
            // 
            this.txtmpkcopy.Enabled = false;
            this.txtmpkcopy.Location = new System.Drawing.Point(137, 88);
            this.txtmpkcopy.Name = "txtmpkcopy";
            this.txtmpkcopy.Size = new System.Drawing.Size(269, 20);
            this.txtmpkcopy.TabIndex = 25;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Location = new System.Drawing.Point(137, 113);
            this.header.Margin = new System.Windows.Forms.Padding(2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(211, 17);
            this.header.TabIndex = 23;
            this.header.Text = "Copy Header (Order, IDs, Compression)";
            this.header.UseVisualStyleBackColor = true;
            this.header.CheckedChanged += new System.EventHandler(this.header_CheckedChanged);
            // 
            // compressbox
            // 
            this.compressbox.AutoSize = true;
            this.compressbox.Location = new System.Drawing.Point(363, 113);
            this.compressbox.Margin = new System.Windows.Forms.Padding(2);
            this.compressbox.Name = "compressbox";
            this.compressbox.Size = new System.Drawing.Size(96, 17);
            this.compressbox.TabIndex = 23;
            this.compressbox.Text = "Compress Files";
            this.compressbox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(137, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 53);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort By";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(146, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Date Modified";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(8, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Name";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Status :";
            // 
            // lbTextRe
            // 
            this.lbTextRe.AutoSize = true;
            this.lbTextRe.Location = new System.Drawing.Point(88, 258);
            this.lbTextRe.Name = "lbTextRe";
            this.lbTextRe.Size = new System.Drawing.Size(0, 13);
            this.lbTextRe.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Name :";
            // 
            // txtNameRe
            // 
            this.txtNameRe.Location = new System.Drawing.Point(137, 62);
            this.txtNameRe.Name = "txtNameRe";
            this.txtNameRe.Size = new System.Drawing.Size(269, 20);
            this.txtNameRe.TabIndex = 18;
            this.txtNameRe.Text = "file.mpk";
            // 
            // btnRePack
            // 
            this.btnRePack.Location = new System.Drawing.Point(191, 136);
            this.btnRePack.Name = "btnRePack";
            this.btnRePack.Size = new System.Drawing.Size(104, 39);
            this.btnRePack.TabIndex = 17;
            this.btnRePack.Text = "RePack";
            this.btnRePack.UseVisualStyleBackColor = true;
            this.btnRePack.Click += new System.EventHandler(this.btnRePack_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Save :";
            // 
            // txtDirectorySaveRe
            // 
            this.txtDirectorySaveRe.Location = new System.Drawing.Point(137, 36);
            this.txtDirectorySaveRe.Name = "txtDirectorySaveRe";
            this.txtDirectorySaveRe.Size = new System.Drawing.Size(269, 20);
            this.txtDirectorySaveRe.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Directory Data :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDirectoryDataRe
            // 
            this.txtDirectoryDataRe.Location = new System.Drawing.Point(137, 10);
            this.txtDirectoryDataRe.Name = "txtDirectoryDataRe";
            this.txtDirectoryDataRe.Size = new System.Drawing.Size(269, 20);
            this.txtDirectoryDataRe.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listboxfiles);
            this.tabPage2.Controls.Add(this.listfiles);
            this.tabPage2.Controls.Add(this.BtnUnPack);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.lbTextUn);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtDirectorySaveUn);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.txtDirectoryDataUn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(497, 282);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "UnPack and List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnUnPack
            // 
            this.BtnUnPack.Location = new System.Drawing.Point(177, 189);
            this.BtnUnPack.Name = "BtnUnPack";
            this.BtnUnPack.Size = new System.Drawing.Size(129, 47);
            this.BtnUnPack.TabIndex = 33;
            this.BtnUnPack.Text = "UnPack";
            this.BtnUnPack.UseVisualStyleBackColor = true;
            this.BtnUnPack.Click += new System.EventHandler(this.BtnUnPack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Status :";
            // 
            // lbTextUn
            // 
            this.lbTextUn.AutoSize = true;
            this.lbTextUn.Location = new System.Drawing.Point(95, 64);
            this.lbTextUn.Name = "lbTextUn";
            this.lbTextUn.Size = new System.Drawing.Size(0, 13);
            this.lbTextUn.TabIndex = 31;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(416, 34);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Save :";
            // 
            // txtDirectorySaveUn
            // 
            this.txtDirectorySaveUn.Location = new System.Drawing.Point(95, 35);
            this.txtDirectorySaveUn.Name = "txtDirectorySaveUn";
            this.txtDirectorySaveUn.Size = new System.Drawing.Size(315, 20);
            this.txtDirectorySaveUn.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "MPK File :";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(416, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "Open";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtDirectoryDataUn
            // 
            this.txtDirectoryDataUn.Location = new System.Drawing.Point(95, 9);
            this.txtDirectoryDataUn.Name = "txtDirectoryDataUn";
            this.txtDirectoryDataUn.Size = new System.Drawing.Size(315, 20);
            this.txtDirectoryDataUn.TabIndex = 22;
            // 
            // listfiles
            // 
            this.listfiles.Location = new System.Drawing.Point(205, 252);
            this.listfiles.Name = "listfiles";
            this.listfiles.Size = new System.Drawing.Size(75, 23);
            this.listfiles.TabIndex = 34;
            this.listfiles.Text = "List Files";
            this.listfiles.UseVisualStyleBackColor = true;
            this.listfiles.Click += new System.EventHandler(this.listfiles_Click);
            // 
            // listboxfiles
            // 
            this.listboxfiles.FormattingEnabled = true;
            this.listboxfiles.Location = new System.Drawing.Point(7, 88);
            this.listboxfiles.Name = "listboxfiles";
            this.listboxfiles.Size = new System.Drawing.Size(484, 95);
            this.listboxfiles.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 388);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "SGO MPK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTextRe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameRe;
        private System.Windows.Forms.Button btnRePack;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDirectorySaveRe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDirectoryDataRe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnUnPack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTextUn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDirectorySaveUn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtDirectoryDataUn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox compressbox;
        private System.Windows.Forms.CheckBox header;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtmpkcopy;
        private System.Windows.Forms.Button listfiles;
        private System.Windows.Forms.ListBox listboxfiles;
    }
}

