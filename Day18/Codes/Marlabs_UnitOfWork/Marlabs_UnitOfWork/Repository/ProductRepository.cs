using Marlabs_UnitOfWork.EntityFramework;
using Marlabs_UnitOfWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marlabs_UnitOfWork.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext application;
        public ProductRepository(ApplicationDbContext _application)
        {
            application = _application;
        }
        public void AddProduct(Product product)
        {
            application.Product.Add(product);
        }

        public bool DeleteProduct(long productId)
        {
            var removed = false;
            Product product = GetProduct(productId);
            if(product != null)
            {
                removed = true;
                application.Product.Remove(product);
            }
            return removed;
        }

        public Product GetProduct(long id)
        {
            return application.Product.Where(p => p.ProductId == id).FirstOrDefault();
        }

        public IEnumerable<Product> GetProducts()
        {
            return application.Product.ToList();
        }
    }
}
