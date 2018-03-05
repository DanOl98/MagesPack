using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SGOMPK
{
    internal static class MpkWriter
    {
        public static void WriteArchive(IList<MpkFileEntry> entries, Stream output)
        {
            using (BinaryWriter binaryWriter = new BinaryWriter(output))
            {
                binaryWriter.Write(Encoding.UTF8.GetBytes(MpkSignature));
                binaryWriter.Write(VersionMinor);
                binaryWriter.Write(VersionMajor);
                binaryWriter.Write((long)entries.Count);
                int num = FirstEntryOffset - (int)output.Position;
                binaryWriter.Write(new byte[num]);
                int num2 = FileHeaderLength * entries.Count;
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
                    output.Position = (long)(68 + i * 256);
                    binaryWriter.Write(entries[i].Id);
                    binaryWriter.Write(position);
                    binaryWriter.Write(fileInfo.Length);
                    binaryWriter.Write(fileInfo.Length);
                    binaryWriter.Write(Encoding.UTF8.GetBytes(fileInfo.Name));
                    output.Position = position2;
                }
            }
        }

        private const string MpkSignature = "MPK\0";
        private const short VersionMajor = 2;
        private const short VersionMinor = 0;
        private const int FileHeaderLength = 256;
        private const int FirstEntryOffset = 68;

    }
}
