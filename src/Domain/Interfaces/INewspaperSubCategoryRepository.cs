using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface INewspaperSubCategoryRepository
    {
        Task<NewspaperSubCategory> Create(NewspaperSubCategory fileCategory);
        Task<List<NewspaperSubCategory>> Create(List<NewspaperSubCategory> fileCategories);
        void Delete(NewspaperSubCategory fileCategory);
    }
}
