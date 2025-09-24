using Microsoft.EntityFrameworkCore;
using techstorecloud.Modelos;

namespace techstorecloud.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
