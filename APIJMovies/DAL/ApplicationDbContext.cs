using Microsoft.EntityFrameworkCore;
using APIJMovies.DAL.Models;

namespace APIJMovies.DAL
{
    public class ApplicationDbContext : DbContext
    {

        //constructor: para poder inicializar la clase base DbContext en otras palabras, virtualizar mi BD
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }
            
        //definir los DBset, tablas que voy a utilizar en mi app
        public DbSet<Category> Categories { get; set; }

    }
}
