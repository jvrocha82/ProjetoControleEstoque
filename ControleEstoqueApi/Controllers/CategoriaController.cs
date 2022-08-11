using ControleEstoque.Domain.Entities;
using ControleEstoque.Domain.Services;
using ControleEstoqueApi.DTOs.Categorias;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriaController
    {
        private readonly CategoriaService _categoriaService;
        public CategoriaController(CategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Categoria categoria) 
        {

            try
            {
              await _categoriaService.CreateAsync(categoria);
                return new ContentResult()
                {
                    StatusCode = 200,
                    Content = "OK"
                };
            }
            catch (Exception error)
            {
                return new ContentResult()
                {
                    StatusCode = 500,
                    Content = $"ERROR: {error}"
                };
            }
        }

    }
}
