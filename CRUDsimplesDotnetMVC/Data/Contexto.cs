using CRUDsimplesDotnetMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDsimplesDotnetMVC.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto>options) : base(options) { 
        }
        public DbSet<Departamento>Departamentos { get; set; }
    }
}
