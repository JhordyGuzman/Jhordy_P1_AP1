using Jhordy_P1_AP1.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Jhordy_P1_AP1.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Ciudades> ciudades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= Data/DCiudad.db");
        }
    }
}