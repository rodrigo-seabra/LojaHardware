using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LojaDeHardware.Models
{
    //[Keyless]
    [Table("VendaHasProduto")]
    public class VendaHasProduto
    {
        [Column("VendaHasProdutoId")]
        [Display(Name = "Código da venda do produto")]
        public int VendaHasProdutoId { get; set; }

        [Column("VendaHasProdutoQtd")]
        [Display(Name = "Quantidade de produto vendido")]
        public int VendaHasProdutoQtd { get; set; }

        [ForeignKey("VendaId")]
        public int VendaId { get; set; }
        public Venda? Venda { get; set; }

        [ForeignKey("ProdutoId")]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }
    }
}
