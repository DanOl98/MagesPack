using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using MetroFramework.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SGOMPK
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (CommonOpenFileDialog open = new CommonOpenFileDialog())
            {
                open.IsFolderPicker = true;
                if (open.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    txtDirectoryDataRe.Text = open.FileName;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (CommonOpenFileDialog save = new CommonOpenFileDialog())
            {
                save.IsFolderPicker = true;
                if (save.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    txtDirectorySaveRe.Text = save.FileName;
                }
            }
        }

        private async void btnRePack_Click(object sender, EventArgs e)
        {
            try
            {
                lbTextRe.Text = "Loading...";
                await Task.Run(delegate
                {
                    Pack();
                });
                lbTextRe.Text = "OK";
            }
            catch
            {
                lbTextRe.Text = "Err...";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (CommonOpenFileDialog open = new CommonOpenFileDialog())
            {
                if (open.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    txtDirectoryDataUn.Text = open.FileName;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (CommonOpenFileDialog save = new CommonOpenFileDialog())
            {
                save.IsFolderPicker = true;
                if (save.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    txtDirectorySaveUn.Text = save.FileName;
                }
            }
        }

        private async void BtnUnPack_Click(object sender, EventArgs e)
        {
            try
            {
                lbTextUn.Text = "Loading...";
                await Task.Run(delegate
                {
                    UnPack();
                });
                lbTextUn.Text = "OK";
            }
            catch
            {
                lbTextUn.Text = "Err";
            }
        }


        private void Pack()
        {
            using (FileStream fileStream = File.Create(Path.Combine(txtDirectorySaveRe.Text, txtNameRe.Text)))
            {
                IEnumerable<FileInfo> ListFileData1 = new DirectoryInfo(txtDirectoryDataRe.Text).GetFiles();
                Func<FileInfo, string> FileInfoName;
                if ((FileInfoName = a.FileinfoName) == null)
                {
                    FileInfoName = (a.FileinfoName = new Func<FileInfo, string>(a.install.PackName));
                }
                IEnumerable<FileInfo> ListFileData2;
                if (radioButton2.Checked)
                    ListFileData2 = ListFileData1.OrderBy(FileInfoName).OrderBy(p => p.CreationTime);
                else
                    ListFileData2 = ListFileData1.OrderBy(FileInfoName);
                Func<FileInfo, int, MpkFileEntry> FileInfo;
                if ((FileInfo = a.Fileinfo) == null)
                {
                    FileInfo = (a.Fileinfo = new Func<FileInfo, int, MpkFileEntry>(a.install.PackFileInfo));
                }
                MpkWriter.WriteArchive(ListFileData2.Select(FileInfo).ToList<MpkFileEntry>(), fileStream);
            }
        }

        private void UnPack()
        {
            using (FileStream fileStream = File.Open(Path.Combine(txtDirectoryDataUn.Text), FileMode.Open, FileAccess.Read))
            {
                MpkReader.ReaderArchive(fileStream, txtDirectorySaveUn.Text);
            }
        }

        [CompilerGenerated]
        [Serializable]
        private sealed class a
        {
            public a()
            {
            }
            static a()
            {
                a.install = new a();
            }

            internal string PackName(FileInfo x)
            {
                return x.Name;
            }

            internal MpkFileEntry PackFileInfo(FileInfo x, int id)
            {
                return new MpkFileEntry(id, x);
            }

            public static readonly a install = new a();
            public static Func<FileInfo, string> FileinfoName;
            public static Func<FileInfo, int, MpkFileEntry> Fileinfo;
        }
    }
}
