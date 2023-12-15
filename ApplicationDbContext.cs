using Microsoft.EntityFrameworkCore;
using WebApplicationIDL2.Controllers.Entidades;

namespace WebApplicationIDL2
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Autor> Autores { get; set; }
    }
    
}
