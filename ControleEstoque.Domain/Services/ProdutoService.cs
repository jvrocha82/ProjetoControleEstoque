using ControleEstoque.Domain.Contracts.Repositoris;
using ControleEstoque.Domain.Contracts.Services;
using ControleEstoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleEstoque.Domain.Services
{
    public class ProdutoService : BaseService<Produto>, IProdutoService
    {
        public ProdutoService(IBaseRepository<Produto> baseRepository) : base(baseRepository)
        {
        }
    }
}
