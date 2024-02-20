using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LojaDeHardware.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        [Column("CategoriaId")]
        [Display(Name = "ID")]
        public int CategoriaId { get; set; }

        [Column("CategoriaNome")]
        [Display(Name = "Nome da categoria")]
        public string CategoriaNome { get; set; } = string.Empty;
    }
}
