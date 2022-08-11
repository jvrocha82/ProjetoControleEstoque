using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque.Domain.Contracts.Repositoris
{
    public interface IBaseRepository<T> : IAsyncDisposable where T : class
    {
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<List<T>> ListAsync();
        Task<T> GetByIdAsync(Guid id);
    }
}
