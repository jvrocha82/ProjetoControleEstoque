using ControleEstoque.Domain.Contracts.Repositoris;
using ControleEstoque.Domain.Contracts.Services;
using ControleEstoque.Domain.Services;
using ControleEstoque.Infra.Data.Context;
using ControleEstoque.Infra.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEstoqueApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IProdutoService, ProdutoService>();
            //services.AddTransient<IProdutoRepository, ProdutoRepository>();
            //services.AddTransient<ICategoriaService, CategoriaService>();
            //services.AddTransient<ICategoriaRepository, CategoriaRepository>();
            //services.AddTransient<DataContext>();
     
            services.AddControllers();

            services.AddSwaggerGen(
                x => x.SwaggerDoc("v1", new OpenApiInfo
                { 
                    Version = "v1",
                    Title = "Api Estoque",
                    Description = "API PARA CONTROLE DE ESTOQUE",
                }));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseSwagger();
            app.UseSwaggerUI(x => x.SwaggerEndpoint("/swagger/v1/swagger.json","APIESTOQUE"));

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
