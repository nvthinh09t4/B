using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class FileStorage
    {
        public string OriginalFileName { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public bool IsDisable { get; set; }
        public DateTime UploadAt { get; set; }
    }
}
