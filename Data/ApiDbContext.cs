using ApiCliente.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCliente.Data
{
    public class ApiDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source= .apiCliente.db;Cache=Shared");
        }

    }
}