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
        private IList<MpkFileEntry> fileentries;
        MpkDetailedEntry[] MPKEntries;
        public void WriteArchive(IList<MpkFileEntry> en, Stream output, bool compress, bool copyheader, string headerdirectory)
        {
            fileentries = en;
            MPKEntries = new MpkDetailedEntry[fileentries.Count];
            string folder = Convert.ToString(fileentries[0].FileInfo.Directory);
            for (int i = 0; i < fileentries.Count; i++)
            {
                MPKEntries[i] = new MpkDetailedEntry();
            }
            using (BinaryWriter binaryWriter = new BinaryWriter(output))
            {
                if (copyheader)
                {
                    using (FileStream fileStream = File.Open(Path.Combine(headerdirectory), FileMode.Open, FileAccess.Read))
                    {
                        ReadArchive(fileStream);
                    }
                }
                else
                {
                    for (int i = 0; i < MPKEntries.Length; i++)
                    {
                        MPKEntries[i].isCompressed = compress;
                        MPKEntries[i].fileName = fileentries[i].FileInfo.Name;
                        MPKEntries[i].Id = i;
                    }
                }
                binaryWriter.Write(Encoding.UTF8.GetBytes(MpkSignature));
                binaryWriter.Write(VersionMinor);
                binaryWriter.Write(VersionMajor);
                binaryWriter.Write((long)MPKEntries.Length);
                int num = FirstEntryOffset - (int)output.Position;
                binaryWriter.Write(new byte[num]);
                int num2 = FileHeaderLength * MPKEntries.Length;
                if (num2 % 2048L != 0L || num2 < 2048L)
                {
                    int n = (int)((num2 / 2048L + 1L) * 2048L) - (num2 + FirstEntryOffset);
                    binaryWriter.Write(new byte[n]);
                }
                binaryWriter.Write(new byte[num2]);
                for (int i = 0; i < MPKEntries.Length; i++)
                {
                    long position = output.Position;
                    using (FileStream fileStream = File.OpenRead(folder + "\\" + MPKEntries[i].fileName))
                    {
                        MPKEntries[i].actualSize = fileStream.Length;
                        if (MPKEntries[i].isCompressed)
                        {
                            byte[] buffer = File.ReadAllBytes(folder + "\\" + MPKEntries[i].fileName);
                            MemoryStream memOutput = new MemoryStream();
                            ZOutputStream zipOut = new ZOutputStream(memOutput, zlibConst.Z_DEFAULT_COMPRESSION);
                            zipOut.Write(buffer, 0, buffer.Length);
                            zipOut.finish();
                            memOutput.Seek(0, SeekOrigin.Begin);
                            byte[] result = memOutput.ToArray();
                            binaryWriter.Write(result);
                            MPKEntries[i].size = (long)result.Length;
                        }
                        else
                        {
                            byte[] buffer = new byte[4096];
                            int count;
                            while ((count = fileStream.Read(buffer, 0, 4096)) != 0)
                            {
                                binaryWriter.Write(buffer, 0, count);
                            }
                            MPKEntries[i].size = MPKEntries[i].actualSize;
                        }
                    }
                    if (MPKEntries[i].size % 2048L != 0L || MPKEntries[i].size < 2048L)
                    {
                        num = (int)((MPKEntries[i].size / 2048L + 1L) * 2048L) - (int)MPKEntries[i].size;
                        if (i < MPKEntries.Length - 1)
                        {
                            binaryWriter.Write(new byte[num]);
                        }
                    }
                    long position2 = output.Position;
                    output.Position = (long)(FirstEntryOffset + i * 256);
                    binaryWriter.Write((int)(MPKEntries[i].isCompressed ? 1 : 0));
                    binaryWriter.Write(MPKEntries[i].Id);
                    binaryWriter.Write(position);
                    binaryWriter.Write(MPKEntries[i].size);
                    binaryWriter.Write(MPKEntries[i].actualSize);
                    binaryWriter.Write(Encoding.UTF8.GetBytes(MPKEntries[i].fileName));
                    int ls = Encoding.UTF8.GetBytes(MPKEntries[i].fileName).Length;
                    if (ls < 224)
                    {
                        binaryWriter.Write(new byte[224 - ls]);
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
                input.Position = 8;
                long count = binaryreader.ReadInt64();
                for (int i = 0; i < count; i++)
                {
                    long fileEntryPos = 64 + i * 256;
                    input.Position = fileEntryPos;
                    bool isCompressed = binaryreader.ReadInt32() == 1;
                    int Id = binaryreader.ReadInt32();
                    long fileDataPos = binaryreader.ReadInt64();
                    long size = binaryreader.ReadInt64();
                    long actualSize = binaryreader.ReadInt64();
                    byte[] buffer = new byte[224];
                    input.Read(buffer, 0, buffer.Length);
                    string fileName = Encoding.UTF8.GetString(buffer).Replace("\0", "").Trim();
                    try
                    {
                        MPKEntries[i].Id = Id;
                        MPKEntries[i].fileName = fileName;
                        MPKEntries[i].isCompressed = isCompressed;
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
