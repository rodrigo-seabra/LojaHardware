using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LojaDeHardware.Models
{
    [Table("EntradaProduto")]
    public class EntradaProduto
    {
        [Column("EntradaProdutoId")]
        [Display(Name = "Cód. Entrada de Produto")]
        public int Id { get; set; }

        [Column("EntradaProdutoQuantidade")]
        [Display(Name = "Quantidade de produtos")]
        public int EntradaProdutoQuantidade { get; set; }

        [Column("EntradaProdutoData")]
        [Display(Name = "Data de entrada do produto")]
        public DateTime EntradaProdutoData { get; set; }

        [ForeignKey("ProdutoId")]
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

    }
}
