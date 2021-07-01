using LaraViEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaraViRepositories.Interfaces
{
    public interface ICategoryRepository
    {
        void AddCategory(Category category);
        void EditCategory(Category category);
        void DeleteCategory(int categoryId);
        Category GetCategoryById(int id);
        IEnumerable<Category> GetAllCategoryes();
    }
}
