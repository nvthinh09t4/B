using ASPNetCore3.IServices;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCore3.ServiceImpl
{
    public class FileService : IFileService
    {
        public Task<byte[]> DownloadFile()
        {
            throw new NotImplementedException();
        }

        public Task<FileStorage> SaveFile()
        {
            throw new NotImplementedException();
        }
    }
}
