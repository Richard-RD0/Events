using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using api_filmes_senai.Domains;

namespace Eveent_.Domains
{
    [Table("TiposEventos")]
    public class TiposEventos
    {
        [Key]
        public Guid IdTipoEventos { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O titulo do tipo de evento e obrigatorio")]
        public string? TituloTipoEvento { get; set; }
    }
}
