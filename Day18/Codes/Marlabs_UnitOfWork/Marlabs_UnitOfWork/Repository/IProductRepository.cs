using Marlabs_UnitOfWork.Models;
using System.Collections.Generic;
namespace Marlabs_UnitOfWork.Repository
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        Product GetProduct(long id);
        IEnumerable<Product> GetProducts();
        bool DeleteProduct(long productId);
    }
}
