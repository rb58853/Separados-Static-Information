using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        
        //DbSet es una coleccion de etidades referentes a la base de datos
        public DbSet<User> users { get; set; }
    }
}
