using Libreria_DLL.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Writers;
using System;
using System.Linq;

namespace Libreria_DLL.Data
{
    public class AppDbInitialer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope()) 
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Titulo = "Titulo1",
                        Descripcion = "Description1",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 7,
                        Genero = "Comedia",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now,
                    },
                     new Book()
                     {
                         Titulo = "Titulo2",
                         Descripcion = "Descripcion2",
                         IsRead = true,
                         DateRead = DateTime.Now.AddDays(-10),
                         Rate = 10,
                         Genero = "Terror",
                         CoverUrl = "https...",
                         DateAdded = DateTime.Now,
                     });
                    context.SaveChanges();
                }
            }
        }

    }
}
