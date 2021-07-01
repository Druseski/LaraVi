using LaraViData;
using LaraViEntities;
using LaraViRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaraViRepositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext _dataContext;

        public CategoryRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void AddCategory(Category category)
        {
            _dataContext.Add(category);
            _dataContext.SaveChanges();
        }

        public void DeleteCategory(int categoryId)
        {
            Category category = GetCategoryById(categoryId);
            _dataContext.Remove(category);
            _dataContext.SaveChanges();
        }

        public void EditCategory(Category category)
        {
            _dataContext.Update(category);
            _dataContext.SaveChanges();
        }

        public IEnumerable<Category> GetAllCategoryes()
        {
            var result = _dataContext.Categories.AsEnumerable();
            return result;
        }

        public Category GetCategoryById(int id)
        {
            var result = _dataContext.Categories.FirstOrDefault(x => x.Id == id);
            return result;
        }
    }
}
