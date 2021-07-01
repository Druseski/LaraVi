using LaraViData;
using LaraViEntities;
using LaraViRepositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaraViRepositories
{
    public class ProductRepository: IProductRepository
    {
        private readonly DataContext _dataContext;

        public ProductRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void AddProduct(Product product)
        {
            _dataContext.Add(product);
            _dataContext.SaveChanges();

        }

        public void DeleteProduct(int productId)
        {
            Product product = GetProductById(productId);
            _dataContext.Remove(product);
            _dataContext.SaveChanges();

        }

        public void EditProduct(Product product)
        {
            _dataContext.Update(product);
            _dataContext.SaveChanges();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var result = _dataContext.Products.AsEnumerable();
            return result;
        }

        public Product GetProductById(int id)
        {
            var result = _dataContext.Products.FirstOrDefault(x => x.Id == id);
            return result;
        }
    }
}
