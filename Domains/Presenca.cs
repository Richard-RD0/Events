using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using api_filmes_senai.Domains;

namespace Eveent_.Domains
{
    [Table("Presenca")]
    public class Presenca
    {
        [Key]
        public Guid IdPresenca { get; set; }

        [Column(TypeName = "BIT")]
        [Required(ErrorMessage = "A situção é obrigatoria")]
        public bool Situacao { get; set; }

        public Guid IdEventos { get; set; }

        [ForeignKey("IdEventos")]
        public Eventos? eventos { get; set; }

        public Guid IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public Usuarios? Usuario { get; set; }
    }
}
 