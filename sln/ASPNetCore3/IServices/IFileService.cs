using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3.IServices
{
    public interface IFileService
    {
        Task<FileStorage> SaveFile();
        Task<byte[]> DownloadFile();
    }
}
