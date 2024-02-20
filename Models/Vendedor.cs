using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LojaDeHardware.Models
{
    [Table("Vendedor")]
    public class Vendedor
    {
        [Column("VendedorId")]
        [Display(Name = "Código do vendedor")]
        public int VendedorId { get; set; }

        [Column("VendedorNome")]
        [Display(Name = "Nome do vendedor")]
        public string VendedorNome { get; set; } = string.Empty;

        [Column("VendedorCPF")]
        [Display(Name = "CPF do vendedor")]
        public string VendedorCPF { get; set; } = string.Empty;

    }
}
