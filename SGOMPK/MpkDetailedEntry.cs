using System.IO;
using System.Runtime.CompilerServices;

namespace SGOMPK
{
    internal sealed class MpkDetailedEntry
    {
        public MpkDetailedEntry()
        {
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
        public long size
        {
            [CompilerGenerated]
            get
            {
                return _Size;
            }
            set
            {
                _Size = value;
            }
        }
        public long actualSize
        {
            [CompilerGenerated]
            get
            {
                return _ActualSize;
            }
            set
            {
                _ActualSize = value;
            }
        }
        public string fileName
        {
            [CompilerGenerated]
            get
            {
                return _FileName;
            }
            set
            {
                _FileName = value;
            }
        }
        public bool isCompressed
        {
            [CompilerGenerated]
            get
            {
                return _isCompressed;
            }
            set
            {
                _isCompressed = value;
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
        private bool _isCompressed;
        private long _ActualSize;
        private long _Size;
        private string _FileName;
        [CompilerGenerated]
        private FileInfo _FileInfo;
    }
}
