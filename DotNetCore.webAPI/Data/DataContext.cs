using DotNetCore.webAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore.webAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {
            
        }

        public DbSet<Evento> Eventos { get; set; }
    }
}