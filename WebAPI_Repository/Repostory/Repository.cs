using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WabAPI_Domain.Models;

namespace WebAPI_Repository.Repostory
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private DbSet<T> entities;


        public Repository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            entities = _applicationDbContext.Set<T>();
        }

        public void Remove(T entity)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
        }


        public T Get(int id)
        {
            return entities.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public void Insert(T entity)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entity");
            }
            var result = entities.Add(entity);
        }

        public void SaveChanges()
        {
            _applicationDbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entities == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
        }
    }
}
