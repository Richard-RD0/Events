using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Eveent_.Domains
{
    [Table("Instituicoes")]
    [Index(nameof(Cnpj), IsUnique = true)]
    public class Instituicoes
    {
        [Key]
        public Guid IdInstituicao { get; set; }

        [Column(TypeName = "VARCHAR(14)")]
        [Required(ErrorMessage = "O Cnpj e obrigatorio")]
        [StringLength(14)]
        public string? Cnpj {  get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O Endereco e obrigatorio")]
        public string? Endereco { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O nome fantasia e obrigatorio")]
        public string? NomeFantasia { get; set; }
    }
} 
 