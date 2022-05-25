using HManager.Dal.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HManager.Dal.Repository
{
    class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private DbSet<T> entities;

        public Repository(AppDbContext appDbContext)
        {
            _context = appDbContext;
            entities = _context.Set<T>();
        }

        public void Delete(T entity)
        {
            if(entity != null)
            {
                entities.Remove(entity);
            }
        }

        public T Get(int Id)
        {
            return entities.Find(Id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(T entity)
        {
            if(entity != null)
            {
                entities.Add(entity);
                _context.SaveChanges();
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            entities.Update(entity);
            _context.SaveChanges();
        }
    }
}
