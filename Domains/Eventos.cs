using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eveent_.Domains
{
    [Table("Evento")]
    public class Eventos
    {
        [Key]
        public Guid IdEventos { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O Tipo de eventos é obrigatorio!")]
        public string? TituloDeEventos { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Descricao do evento e obrigatorio!")]
        public string? Descricao { get; set; }

        [Column(TypeName = "DATETIME")]
        [Required(ErrorMessage = "A data do evento e obrigatorio!")]
        public DateTime? DataEvento { get; set; }

        public Presenca? PresencasEvento { get; set; }

        public Guid IdTipoEventos { get; set; }

        [ForeignKey("IdTipoEventos")]
        public TiposEventos? tiposEvento { get; set; }

        public Guid IdInstituicao { get; set; }

        [ForeignKey("IdInstituicao")]
        public Instituicoes? Instituicao { get; set; }
    }
}
 