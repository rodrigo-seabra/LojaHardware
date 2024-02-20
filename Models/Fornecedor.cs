using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LojaDeHardware.Models
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        [Column("FornecedorId")]
        [Display(Name = "Código do fornecedor")]
        public int FornecedorId { get; set; }

        [Column("FornecedorCNPJ")]
        [Display(Name = "CNPJ do Fornecedor")]
        public string FornecedorCNPJ { get; set; } = string.Empty;

        [Column("FornecedorNome")]
        [Display(Name = "Nome do Fornecedor")]
        public string FornecedorNome { get; set; } = string.Empty;
    }
}
