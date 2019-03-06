using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using zlib;

namespace SGOMPK
{
    internal class MpkWriter
    {
        private IList<MpkFileEntry> entries;
        public void WriteArchive(IList<MpkFileEntry> en, Stream output, bool compress, bool copyheader, string headerdirectory)
        {
            entries = en;
            using (BinaryWriter binaryWriter = new BinaryWriter(output))
            {
                if (copyheader)
                {
                    using (FileStream fileStream = File.Open(Path.Combine(headerdirectory), FileMode.Open, FileAccess.Read))
                    {
                       ReadArchive(fileStream);
                    }
                }
                binaryWriter.Write(Encoding.UTF8.GetBytes(MpkSignature));
                binaryWriter.Write(VersionMinor);
                binaryWriter.Write(VersionMajor);
                binaryWriter.Write((long)entries.Count);
                int num = FirstEntryOffset - (int)output.Position;
                binaryWriter.Write(new byte[num]);
                int num2 = FileHeaderLength * entries.Count;
                if (num2 % 2048L != 0L || num2 < 2048L)
                {
                    int n = (int)((num2 / 2048L + 1L) * 2048L) - (num2 + FirstEntryOffset);
                    binaryWriter.Write(new byte[n]);
                }
                binaryWriter.Write(new byte[num2]);
                for (int i = 0; i < entries.Count; i++)
                {
                    FileInfo fileInfo = entries[i].FileInfo;
                    long position = output.Position;
                    using (FileStream fileStream = fileInfo.OpenRead())
                    {
                        byte[] buffer = new byte[4096];
                        int count;
                        while ((count = fileStream.Read(buffer, 0, 4096)) != 0)
                        {
                            binaryWriter.Write(buffer, 0, count);
                        }
                    }
                    if (fileInfo.Length % 2048L != 0L || fileInfo.Length < 2048L)
                    {
                        num = (int)((fileInfo.Length / 2048L + 1L) * 2048L) - (int)fileInfo.Length;
                        if (i < entries.Count - 1)
                        {
                            binaryWriter.Write(new byte[num]);
                        }
                    }
                    long position2 = output.Position;
                    output.Position = (long)(FirstEntryOffset + i * 256);
                    binaryWriter.Write((int)(compress ? 1 : 0));
                    binaryWriter.Write(entries[i].Id);
                    binaryWriter.Write(position);
                    binaryWriter.Write(fileInfo.Length);
                    if (compress)
                    {
                        using (FileStream str = fileInfo.OpenRead())
                        {
                            byte[] buffer = File.ReadAllBytes(fileInfo.Directory + "\\" +  fileInfo.Name);
                            /*
                            MemoryStream memOutput = new MemoryStream();
                            ZOutputStream zipOut = new ZOutputStream(memOutput, zlibConst.Z_DEFAULT_COMPRESSION);

                            zipOut.Write(buffer, 0, buffer.Length);
                            zipOut.finish();

                            memOutput.Seek(0, SeekOrigin.Begin);
                            byte[] result = memOutput.ToArray();
                            binaryWriter.Write((long) result.Length);*/
                            MemoryStream memOutput = new MemoryStream();
                            ZOutputStream zipOut = new ZOutputStream(memOutput);

                            zipOut.Write(buffer, 0, buffer.Length);
                            zipOut.finish();

                            memOutput.Seek(0, SeekOrigin.Begin);
                            byte[] result = memOutput.ToArray();
                            binaryWriter.Write((long)result.Length);
                        }

                    }
                    else
                    {
                        binaryWriter.Write(fileInfo.Length);
                    }
                    binaryWriter.Write(Encoding.UTF8.GetBytes(fileInfo.Name));
                    int ls = Encoding.UTF8.GetBytes(fileInfo.Name).Length;
                    if (ls < 224)
                    {
                        binaryWriter.Write(new byte[224-ls]);
                    }
                    output.Position = position2;
                }
            }
        }

        private const string MpkSignature = "MPK\0";
        private const short VersionMajor = 2;
        private const short VersionMinor = 0;
        private const int FileHeaderLength = 256;
        private const int FirstEntryOffset = 64;
        public void ReadArchive(Stream input)
        {
            using (BinaryReader binaryreader = new BinaryReader(input))
            {
                int count = 0;
                long endReadOffSet = input.Length;
                while (count<entries.Count)
                {
                    long fileEntryPos = 68 + count * 256;
                    input.Position = fileEntryPos;
                    long stt = binaryreader.ReadInt32();
                    long fileDataPos = binaryreader.ReadInt64();
                    long fileSize1 = binaryreader.ReadInt64();
                    long fileSize2 = binaryreader.ReadInt64();
                    long fileDataMaxRange = fileDataPos + fileSize1;
                    try
                    {
                        entries[count].Id = (Int32)stt;
                        count += 1;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                }
            }
        }
    }
    
}
