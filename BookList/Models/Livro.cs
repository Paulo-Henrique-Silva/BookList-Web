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
        [Required]
        [MaxLength(13)]
        public string? Isbn { get; set; }

        [Column("titulo")]
        [Required]
        [MaxLength(80)]
        public string? Titulo { get; set; }

        [Column("autor")]
        [Required]
        [MaxLength(80)]
        public string? Autor { get; set; }
    }
}
