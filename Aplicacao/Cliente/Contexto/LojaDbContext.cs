using Aplicacao.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Aplicacao.Contexto
{
    public class LojaDbContext : DbContext
    {
        public LojaDbContext(DbContextOptions<LojaDbContext> pOpcoes) : base(pOpcoes)
        {

        }

       public DbSet<Usuario> Usuario { get; set; }
       public DbSet<Nivel> Nivel{ get; set; }
    }
}
