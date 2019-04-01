using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGOMPK
{
    public partial class ListFiles : Form
    {
        MpkDetailedEntry[] entries;
        public ListFiles()
        {
            InitializeComponent();
        }

        private void ListFiles_Load(object sender, EventArgs e)
        {
        }
        public void addStream(FileStream fileStream)
        {
            ReadArchive(fileStream);

        }
        public void ReadArchive(Stream input)
        {
            using (BinaryReader binaryreader = new BinaryReader(input))
            {
                input.Position = 8;
                long count = binaryreader.ReadInt64();
                entries = new MpkDetailedEntry[count];
                for (int i = 0; i<count; i++)
                {
                    entries[i] = new MpkDetailedEntry();
                    long fileEntryPos = 64 + i * 256;
                    input.Position = fileEntryPos;
                    entries[i].isCompressed = binaryreader.ReadInt32()==1;
                    entries[i].Id = binaryreader.ReadInt32();
                    long fileDataPos = binaryreader.ReadInt64();
                    entries[i].size = binaryreader.ReadInt64();
                    entries[i].actualSize = binaryreader.ReadInt64();
                    byte[] buffer = new byte[224];
                    input.Read(buffer, 0, buffer.Length);
                    entries[i].fileName = Encoding.UTF8.GetString(buffer).Replace("\0", "");
                }
                System.GC.Collect();
            }
        }

        private void ListFiles_Shown(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Num", 40, HorizontalAlignment.Left);
            listView1.Columns.Add("ID", 40, HorizontalAlignment.Left);
            listView1.Columns.Add("Name", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Compressed", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("Size", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Actual Size", 100, HorizontalAlignment.Left);
            for (int i = 0; i < entries.Count(); i++)
            {
                listView1.Items.Add(new ListViewItem(new[] { Convert.ToString(i), Convert.ToString(entries[i].Id), entries[i].fileName , entries[i].isCompressed ? "Yes" : "No", Convert.ToString(entries[i].size), Convert.ToString(entries[i].actualSize)}));
            }
        }
    }
}
