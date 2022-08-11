using ControleEstoque.Domain.Contracts.Repositoris;
using ControleEstoque.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque.Infra.Data.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly DataContext dataContext;

        protected BaseRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task CreateAsync(T entity)
        {
            dataContext.Entry(entity).State = EntityState.Added;
            await dataContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            dataContext.Entry(entity).State = EntityState.Deleted;
            await dataContext.SaveChangesAsync();
        }

        public async ValueTask DisposeAsync()
        {
            GC.SuppressFinalize(this);
            await dataContext.DisposeAsync();

        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await dataContext.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> ListAsync()
        {
            return await dataContext.Set<T>().ToListAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            dataContext.Entry(entity).State = EntityState.Modified;
            await dataContext.SaveChangesAsync();
        }
    }
}
