using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LojaDeHardware.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("ProdutoId")]
        [Display(Name = "Código do produto")]
        public int ProdutoId { get; set; }

        [Column("ProdutoNome")]
        [Display(Name = "Nome do produto")]
        public string ProdutoNome { get; set; } = string.Empty;

        [Column("ProdutoPreco")]
        [Display(Name = "Preço do produto")]
        public decimal ProdutoPreco { get; set; }

        [Column("ProdutoEstoque")]
        [Display(Name = "Quantidade de produto no estoque")]
        public int ProdutoEstoque { get; set; }

        [ForeignKey("CategoriaId")]
        [Display(Name = "Código da categoria")]
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }

        [ForeignKey("FornecedorId")]
        [Display(Name = "Código do Fornecedor")]
        public int FornecedorId { get; set; }
        public Fornecedor? Fornecedor { get; set; }

    }
}
