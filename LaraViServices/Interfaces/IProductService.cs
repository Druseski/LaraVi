using LaraViEntities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaraViServices.Interfaces
{
    public interface IProductService
    {
        void AddProduct(Product product);
        void EditProduct(Product product);
        void DeleteProduct(int productId);
        Product GetProductById(int id);
        IEnumerable<Product> GetAllProducts();
        Tuple<List<SelectListItem>> FillDropdowns(
            IEnumerable<Category> categories);
    }
}
