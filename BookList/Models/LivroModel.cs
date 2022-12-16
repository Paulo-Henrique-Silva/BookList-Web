using System.ComponentModel.DataAnnotations;

namespace BookList.Models
{
    public class LivroModel
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Isbn { get; set; }

        [Required]
        public string Titulo { get; set; }

        [Required]
        public string Autor { get; set; }
    }
}
