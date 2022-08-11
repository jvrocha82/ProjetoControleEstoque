using ControleEstoque.Domain.Contracts.Repositoris;
using ControleEstoque.Domain.Entities;
using ControleEstoque.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControleEstoque.Infra.Data.Repositories
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}
