using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LojaDeHardware.Models
{
    [Table("MeioPagamento")]
    public class MeioPagamento
    {
        [Column("MeioPagamentoId")]
        [Display(Name = "Id")]
        public int MeioPagamentoId { get; set; }

        [Column("MeioPagamentoTipo")]
        [Display(Name = "Meio de pagamento")]
        public string MeioPagamentoTipo { get; set; } = string.Empty;
    }
}
