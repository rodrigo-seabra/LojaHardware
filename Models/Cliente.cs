using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaDeHardware.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("ClienteId")]
        [Display(Name = "Código do cliente")]
        public int ClienteId { get; set; }

        [Column("ClienteNome")]
        [Display(Name = "Nome do cliente")]
        public string ClienteNome { get; set; } = string.Empty;

        [Column("ClienteTel")]
        [Display(Name = "Telefone do cliente")]
        public string ClienteTel { get; set; } = string.Empty;

        [Column("ClienteCPF")]
        [Display(Name = "CPF do cliente")]
        public string CPFCliente { get; set; } = string.Empty;

        [Column("ClienteRua")]
        [Display(Name = "Rua do cliente")]
        public string ClienteRua { get; set; } = string.Empty;

        [Column("ClientePais")]
        [Display(Name = "País do cliente")]
        public string ClientePais { get; set; } = string.Empty;

        [Column("ClienteEstado")]
        [Display(Name = "Estado do cliente")]
        public string ClienteEstado { get; set; } = string.Empty;

        [Column("ClienteCEP")]
        [Display(Name = "CEP do cliente")]
        public string ClienteCEP { get; set; } = string.Empty;


    }
}
