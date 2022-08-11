using System;
using System.Collections.Generic;
using System.Text;

namespace ControleEstoque.Domain.Entities
{
   public class Produto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Qtd { get; set; }


    }
}
