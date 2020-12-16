using Practica3.Models;
using Microsoft.EntityFrameworkCore;

namespace Practica3.Data
{
    public class RegistroContext : DbContext
    {
        public DbSet<Registro> Registros { get; set; }

        public RegistroContext(DbContextOptions pmi) : base(pmi) {

        }
    }
}