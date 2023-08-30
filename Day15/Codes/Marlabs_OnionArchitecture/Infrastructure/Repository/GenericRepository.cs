using Domain.EntityFramework;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq; 

namespace Infrastructure.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        public readonly ApplicationDbContext dbcontext;
        private DbSet<T> entities;

        public GenericRepository(ApplicationDbContext _dbcontext)
        {
            this.dbcontext = _dbcontext;
            entities = dbcontext.Set<T>();
        }

        public void Delete(T entity)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("Entity Missing");
            }
            else
            {
                entities.Remove(entity); //remove from local
                dbcontext.SaveChanges(); //Applying in db
            }
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public T GetT(long Id)
        {
            return entities.SingleOrDefault(s=> s.Id == Id);
        }

        public void Insert(T entity)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("Entity is missing");
            }
            else
            {
                entities.Add(entity);
                dbcontext.SaveChanges();
            }
        }

        public void Remove(T entity)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("Entity is missing");
            }
            else
            {
                entities.Remove(entity);
                //dbcontext.SaveChanges();
            }
        }

        public void SaveChanges()
        {
            dbcontext.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("Entity is missing");
            }
            else
            {
                entities.Update(entity);
                dbcontext.SaveChanges();
            }
        }
    }
}
