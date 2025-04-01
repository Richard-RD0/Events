using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using api_filmes_senai.Domains;

namespace Eveent_.Domains
{
    [Table("ComentarioEvento")]
    public class ComentarioEvento
    {
        [Key]
        public Guid IdComentarioEvento { get; set; }

        [Column(TypeName = "VARCHAR(50)")]  
        [Required(ErrorMessage = "A descrição e obrigatoria")]
        public string? Descricao { get; set; }

        [Column(TypeName = "BIT")]
        [Required(ErrorMessage = "O Exibir e obrigatoria")]
        public bool? Exibe { get; set; }

        public Guid IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public Usuarios? Usuario { get; set; }

        public Guid IdEventos { get; set; }

        [ForeignKey("IdEventos")]
        public Eventos? Eventos { get; set; }
    }
}
