using EscolaCleanArch.Infra.Data.Context;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaCleanArch.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Criando servi�o e obtendo uma inst�ancia do dbContext
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                try
                {
                    var context = services.GetRequiredService<ApplicationDbContext>();
                    context.Database.Migrate();
                }
                catch (Exception ex)
                {
                    // Se ocorrer alguma excess�o ser� gerado log aqui
                    var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "Ocorreu um erro na Migra��o ou alimenta��o dos dados");
                }
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
