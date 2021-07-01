using LaraViEntities;
using LaraViRepositories.Interfaces;
using LaraViServices.Interfaces;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaraViServices
{
    public class ProductService: IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public void EditProduct(Product product)
        {
            _productRepository.EditProduct(product);
            
        }

        public Tuple<List<SelectListItem>> FillDropdowns(IEnumerable<Category> categories)
        {
            List<SelectListItem> Categories = new List<SelectListItem>
            {
                new SelectListItem {Value= "0" , Text = "Select Category..."}
            };
            foreach (var category in categories)
            {

                Categories.Add(new SelectListItem { Value = category.Id.ToString(), Text = category.Name });

            }
            return Tuple.Create(Categories);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var result = _productRepository.GetAllProducts();
            return result;
        }

        public Product GetProductById(int id)
        {
            var result = _productRepository.GetProductById(id);
            return result;
        }
    }
}
