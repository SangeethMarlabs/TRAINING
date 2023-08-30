using Domain.Models;
using System.Collections.Generic;

namespace Infrastructure.Repository
{
    public interface IGenericRepository<T> where T : BaseEntity //T represent User and UserProfile
    {
        IEnumerable<T> GetAll();
        T GetT(long Id);

        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChanges();
    }
}
