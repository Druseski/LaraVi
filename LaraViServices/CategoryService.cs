using LaraViEntities;
using LaraViRepositories.Interfaces;
using LaraViServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaraViServices
{
    public class CategoryService: ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public void AddCategory(Category category)
        {
            _categoryRepository.AddCategory(category);
        }

        public void DeleteCategory(int categoryId)
        {
            _categoryRepository.DeleteCategory(categoryId);
        }

        public void EditCategory(Category category)
        {
            _categoryRepository.EditCategory(category);
        }

        public IEnumerable<Category> GetAllCategoryes()
        {
            var result = _categoryRepository.GetAllCategoryes();
            return result;
        }

        public Category GetCategoryById(int id)
        {
            var result = _categoryRepository.GetCategoryById(id);
            return result;
        }
    }
}
