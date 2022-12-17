using BookList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookList.Pages.GerenciamentoLista
{
    public class AlterarModel : PageModel
    {
        private readonly ApplicationDbContext contexto;

        [BindProperty]
        public Livro LivroASerAlterado { get; set; } = new Livro();

        public AlterarModel(ApplicationDbContext contexto)
        {
            this.contexto = contexto;
        }

        public void OnGet(int id)
        {
            LivroASerAlterado = contexto.Livros.Find(id);
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Livro livroNoBd = contexto.Livros.Find(LivroASerAlterado.Id);
                livroNoBd.Isbn = LivroASerAlterado.Isbn;
                livroNoBd.Titulo = LivroASerAlterado.Titulo;
                livroNoBd.Autor = LivroASerAlterado.Autor;
                contexto.SaveChanges();

                return RedirectToPage("/Index");
            }
            else
            {
                return Page(); //renderiza a mesma pagina novamente
            }
        }
    }
}
