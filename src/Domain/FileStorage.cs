using Domain.Common;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class FileStorage : BaseEntity
    {
        public string OriginFullPath { get; set; }

        public string OriginFileName { get; set; }

        public string OriginFileExtension { get; set; }

        public string StorageFullPath { get; set; }

        public string StorageFileName { get; set; }

        public string StorageFileExtension { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public bool IsDisable { get; set; }
        public DateTime UploadAt { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
        public IList<FileCategory> Categories { get; set; }
    }
}
