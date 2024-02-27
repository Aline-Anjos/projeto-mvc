using ProjetoMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjetoMVC.NewFolder

{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext>options): base(options)
        { 

        }
        public DbSet<Contato>Contatos { get; set; }
    }
}
