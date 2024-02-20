using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LojaDeHardware.Models
{
    [Table("Venda")]
    public class Venda
    {
        [Column("VendaId")]
        [Display(Name = "Código da venda")]
        public int VendaId { get; set; }

        [Column("VendaValorTotal")]
        [Display(Name = "Valor total da venda")]
        public decimal VendaValorTotal { get; set; }

        [Column("VendaData")]
        [Display(Name = "Data da venda")]
        public DateTime VendaData { get; set; }

        [ForeignKey("ClienteId")]
        [Display(Name = "Código do cliente")]
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }

        [ForeignKey("VendedorId")]
        [Display(Name = "Código do Vendedor")]
        public int VendedorId { get; set; }
        public Vendedor? Vendedor { get; set; }

        [ForeignKey("MeioPagamentoId")]
        [Display(Name = "Código do Meio de Pagamento")]
        public int MeioPagamentoId { get; set; }
        public MeioPagamento? MeioPagamento { get; set; }

        [NotMapped] //para nao ser criado no banco de dados
        public List<VendaHasProduto>? ProdutosList { get; set; }
    }
}
