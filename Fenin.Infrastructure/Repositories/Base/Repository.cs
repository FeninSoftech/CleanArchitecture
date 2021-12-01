using Fenin.Infrastructure.Base;
using Fenin.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fenin.Infrastructure.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly ProductContext _productContext;
        public Repository(ProductContext productContext)
        {
            _productContext = productContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _productContext.Set<T>().AddAsync(entity);
            await _productContext.SaveChangesAsync();
            return entity;
        }
        public async Task DeleteAsync(T entity)
        {
            _productContext.Set<T>().Remove(entity);
            await _productContext.SaveChangesAsync();
        }
        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _productContext.Set<T>().ToListAsync();
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await _productContext.Set<T>().FindAsync(id);
        }
    }
}
