using Microsoft.EntityFrameworkCore;

namespace DioMvcASPNET.Models
{

    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=DioMvcASPNET;Integrated Security=True");
        }
    }
}