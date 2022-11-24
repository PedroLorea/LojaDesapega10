using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using LojaDesapega10.Models;

namespace LojaDesapega10.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                if (context.Produto.Any())
                {
                    return;   // DB has been seeded
                }

                context.Produto.AddRange(
                    new Produto
                    {
                        Nome = "Bicicleta",
                        Data = DateTime.Parse("2022-2-05"),
                        Descricao = "BMX - Ano 2020 - Estado de Zero",
                        Categoria = "Transporte",
                        Preco = 1000
                    },

                    new Produto
                    {
                        Nome = "Mesa de Jantar 8 Lugares",
                        Data = DateTime.Parse("2021-5-10"),
                        Descricao = "Mesa de Jantar de 8 Lugares, semi nova, 3 anos de uso",
                        Categoria = "Móveis",
                        Preco = 2000
                    },

                    new Produto
                    {
                        Nome = "Notebook Gamer ASUS",
                        Data = DateTime.Parse("2022-8-22"),
                        Descricao = "Placa gamer GEFORECE GTX 1050Ti - Ram de 8GB - Processador Intel i5",
                        Categoria = "Eletrônicos",
                        Preco = 3900
                    },

                    new Produto
                    {
                        Nome = "Televisão LG 42 polegadas",
                        Data = DateTime.Parse("2022-8-22"),
                        Descricao = "Televisão com 2 anos de uso",
                        Categoria = "Eletrônicos",
                        Preco = 1500
                    }
                );
                context.SaveChanges();
            }
        }
    }
}