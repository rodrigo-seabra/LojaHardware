using Microsoft.EntityFrameworkCore;
using LojaDeHardware.Models;

namespace LojaDeHardware.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<Produto>? Produto { get; set; }
        public DbSet<Vendedor>? Vendedor { get; set; }
        public DbSet<Categoria>? Categoria { get; set; }
        public DbSet<Fornecedor>? Fornecedor { get; set; }
        public DbSet<Cliente>? Cliente { get; set; }
        public DbSet<MeioPagamento>? MeioPagamento { get; set; }
        public DbSet<Venda>? Venda { get; set; }
        public DbSet<VendaHasProduto>? VendaHasProduto { get; set; }
        public DbSet<LojaDeHardware.Models.EntradaProduto> EntradaProduto { get; set; } = default!;



    }
}
