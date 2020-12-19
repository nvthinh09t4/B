using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IFileCategoryRepository 
    {
        Task<FileCategory> Create(FileCategory fileCategory);
        Task<List<FileCategory>> Create(List<FileCategory> fileCategories);
        void Delete(FileCategory fileCategory);
    }
}
