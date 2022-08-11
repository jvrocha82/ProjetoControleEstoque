using ControleEstoque.Domain.Contracts.Repositoris;
using ControleEstoque.Domain.Contracts.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque.Domain.Services
{
    public abstract class BaseService<T> : IBaseServices<T> , IAsyncDisposable where T : class 
    {
        protected readonly IBaseRepository<T> baseRepository;

        public BaseService(IBaseRepository<T> baseRepository)
        {
            this.baseRepository = baseRepository;
        }

        public async Task CreateAsync(T entity)
        {
           await baseRepository.CreateAsync(entity);
        }

        public async Task DeleteAsync(T entity)
        {
            await baseRepository.DeleteAsync(entity);
        }

        public async ValueTask DisposeAsync()
        {
            await baseRepository.DisposeAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
           return await baseRepository.GetByIdAsync(id);
        }

        public async Task<List<T>> ListAsync()
        {
            return await baseRepository.ListAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            await baseRepository.UpdateAsync(entity);
        }
    }
}
