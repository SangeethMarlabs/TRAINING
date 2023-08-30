using Marlabs_UnitOfWork.EntityFramework;
using Marlabs_UnitOfWork.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Marlabs_UnitOfWork.UOW
{
    public class UnitOfWorkUOW : IUnitOfWorkUOW
    {
        private readonly ApplicationDbContext dbContext;
        public UnitOfWorkUOW(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        private IUserRepository _User;

        private IProductRepository _Product;

        public IUserRepository User
        {
            get
            {
                if(this._User == null)
                {
                    this._User = new UserRepository(dbContext);
                }
                return this._User;
            }
        }

        public IProductRepository Product
        {
            get
            {
                if(this._Product == null)
                {
                    this._Product = new ProductRepository(dbContext);
                }
                return this._Product;
            }
        }

        public int Complete()
        {
            return dbContext.SaveChanges();
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}
