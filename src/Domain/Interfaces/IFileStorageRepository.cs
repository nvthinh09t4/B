using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IFileStorageRepository : IBaseRepository<FileStorage>
    {
        Task<List<FileStorage>> GetFilesByUserId(string userId);
        Task<FileStorage> GetFileByAlternativeName(string name);
    }
}
