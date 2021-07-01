using LaraViEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaraViServices.Interfaces
{
    public interface ICategoryService
    {
        void AddCategory(Category category);
        void EditCategory(Category category);
        void DeleteCategory(int categoryId);
        Category GetCategoryById(int id);
        IEnumerable<Category> GetAllCategoryes();
    }
}
