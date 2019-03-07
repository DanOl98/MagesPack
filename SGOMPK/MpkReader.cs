using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SGOMPK
{
    internal static class MpkReader
    {
        public static void ReaderArchive(Stream input, string save, ListBox lb)
        {
            using (BinaryReader binaryreader = new BinaryReader(input))
            {
                input.Position = 8;
                long count = binaryreader.ReadInt64();
                MpkDetailedEntry[] entries = new MpkDetailedEntry[count];
                lb.Invoke((MethodInvoker)delegate {
                    // Running on the UI thread
                    lb.Items.Clear();
                });
                for (int i = 0; i < count; i++)
                {
                    entries[i] = new MpkDetailedEntry();
                    long fileEntryPos = 64 + i * 256;
                    input.Position = fileEntryPos;
                    entries[i].isCompressed = binaryreader.ReadInt32() == 1;
                    entries[i].Id = binaryreader.ReadInt32();
                    long fileDataPos = binaryreader.ReadInt64();
                    entries[i].size = binaryreader.ReadInt64();
                    entries[i].actualSize = binaryreader.ReadInt64();
                    byte[] buffer = new byte[224];
                    input.Read(buffer, 0, buffer.Length);
                    entries[i].fileName = Encoding.UTF8.GetString(buffer).Replace("\0", "");
                    input.Position = fileDataPos;
                    long fileDataMaxRange = fileDataPos + entries[i].size;
                    
                    lb.Invoke((MethodInvoker)delegate {
                        // Running on the UI thread
                        lb.Items.Add("Extracting " + entries[i].fileName);
                        lb.Refresh();
                        lb.TopIndex = lb.Items.Count - 1;
                    });
                    using (FileStream fileStream = File.Create(Path.Combine(save, entries[i].fileName)))
                    {
                        int blockSize = 2048;
                        while (input.Position != fileDataMaxRange)
                        {
                            if (blockSize < entries[i].size)
                            {
                                buffer = new byte[entries[i].size];
                            }
                            else
                            {
                                buffer = new byte[entries[i].size];
                            }
                            input.Read(buffer, 0, buffer.Length);
                            fileStream.Write(buffer, 0, buffer.Length);
                            fileStream.Flush();
                        }
                        fileStream.Close();
                    }
                }
                System.GC.Collect();
            }
        }
    }
}
