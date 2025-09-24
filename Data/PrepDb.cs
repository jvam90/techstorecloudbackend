using techstorecloud.Modelos;

namespace techstorecloud.Data
{
    public static class PrepDb
    {
        // Como essa classe vai ser chamada pelo Program.cs, é necessário adicionar o using Microsoft.AspNetCore.Builder.
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());

            }
        }

        private static void SeedData(AppDbContext context)
        {
            // Verifica se já existe algum registro na tabela Platforms. Se houver, não continua com o processo de seed.
            if (!context.Produtos.Any())
            {
                Console.WriteLine("--> Inserindo dados...");

                context.Produtos.AddRange(
                    new Produto() { Nome = "Smartphone Samsung", Preco = "899.99", Estoque = "20", Categoria = "Eletrônicos" },
                    new Produto() { Nome = "Notebook Dell", Preco = "2499.99", Estoque = "8", Categoria = "Informática" },
                    new Produto() { Nome = "Tênis Nike", Preco = "299.99", Estoque= "25", Categoria = "Esportes" }
                );

                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> Dados já inseridos");
            }
        }
    }
}
