using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3.Models
{
    public class UploadFileViewModel
    {
        public IFormFile FileUpload { get; set; }
    }
}
