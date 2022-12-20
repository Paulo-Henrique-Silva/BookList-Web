using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookList.Models
{
    [Table("tb_livros")]
    public class Livro
    {
        [Column("id")]
        [Key]
        [Required]
        public int Id { get; set; }

        [Column("isbn")]
        [DisplayName("ISBN")]
        [Required(ErrorMessage = "O campo de 'ISBN' é obrigatório.")]
        [MaxLength(13, ErrorMessage = "O campo de ISBN só pode conter no máximo 13 caracteres.")]
        public string? Isbn { get; set; }

        [Column("titulo")]
        [DisplayName("Título")]
        [Required(ErrorMessage = "O campo de 'Título' é obrigatório.")]
        [MaxLength(80, ErrorMessage = "O campo de 'Título' só pode conter no máximo 80 caracteres.")]
        public string? Titulo { get; set; }

        [Column("autor")]
        [DisplayName("Autor")]
        [Required(ErrorMessage = "O campo de 'Autor' é obrigatório.")]
        [MaxLength(80, ErrorMessage = "O campo de 'Autor' só pode conter no máximo 80 caracteres.")]
        public string? Autor { get; set; }
    }
}
