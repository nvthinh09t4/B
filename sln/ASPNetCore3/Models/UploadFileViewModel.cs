using Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3.Models
{
    public class UploadFileViewModel
    {
        public IFormFile FileUpload { get; set; }
        public List<long> CategoriesID { get; set; } = new List<long>();
        public List<FileStorage> Files { get; set; }
        public long CategoryID { get; set; }
        public int PageSize { get; set; }
        public int PageIndex { get; set; }
        public string Search { get; set; }
    }
}
