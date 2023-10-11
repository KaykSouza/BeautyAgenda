using Microsoft.EntityFrameworkCore;
using BelezaAPI.Dominio;

namespace BelezaAPI.Dados
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        //public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Cliente> Clientes => Set<Cliente>();

        public DbSet<Servico> Servicos => Set<Servico>();

    }
}