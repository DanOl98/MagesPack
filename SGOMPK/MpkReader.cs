using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SGOMPK
{
    internal static class MpkReader
    {
        public static void ReaderArchive(Stream input, string save)
        {
            using (BinaryReader binaryreader = new BinaryReader(input))
            {
                int count = 0;
                long endReadOffSet = input.Length;
                while (input.Position != endReadOffSet)
                {
                    long fileEntryPos = 68 + count * 256;
                    input.Position = fileEntryPos;
                    long stt = binaryreader.ReadInt32();
                    long fileDataPos = binaryreader.ReadInt64();
                    long fileSize1 = binaryreader.ReadInt64();
                    long fileSize2 = binaryreader.ReadInt64();
                    long fileDataMaxRange = fileDataPos + fileSize1;
                    byte[] buffer = new byte[228];
                    input.Read(buffer, 0, buffer.Length);
                    string fileName = Encoding.UTF8.GetString(buffer).Replace("\0", "");
                    input.Position = fileDataPos;
                    using (FileStream fileStream = File.Create(Path.Combine(save, fileName)))
                    {
                        int blockSize = 2048;
                        while (input.Position != fileDataMaxRange)
                        {
                            if (blockSize < fileSize1)
                            {
                                buffer = new byte[fileSize1];
                            }
                            else
                            {
                                buffer = new byte[blockSize];
                            }
                            input.Read(buffer, 0, buffer.Length);
                            fileStream.Write(buffer, 0, buffer.Length);
                            fileStream.Flush();
                        }
                        fileStream.Close();
                    }
                    count += 1;
                }
            }
        }
    }
}
