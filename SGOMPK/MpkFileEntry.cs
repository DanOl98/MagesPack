using System.IO;
using System.Runtime.CompilerServices;

namespace SGOMPK
{
    internal sealed class MpkFileEntry
    {
        public MpkFileEntry(int id, FileInfo fileInfo)
        {
            Id = id;
            FileInfo = fileInfo;
        }

        public int Id
        {
            [CompilerGenerated]
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
            }
        }

        public FileInfo FileInfo
        {
            [CompilerGenerated]
            get
            {
                return _FileInfo;
            }
            set
            {
                _FileInfo = value;
            }
        }

        [CompilerGenerated]
        private int _Id;
        [CompilerGenerated]
        private FileInfo _FileInfo;
    }
}
