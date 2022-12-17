using BookList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookList.Pages.GerenciamentoLista
{
    public class AdicionarModel : PageModel
    {
        private readonly ApplicationDbContext contexto;

        [BindProperty] //OnPost, o objeto de livro será enviado ao método.
        public Livro NovoLivro { get; set; } = new Livro();

        public AdicionarModel(ApplicationDbContext contexto)
        {
            this.contexto = contexto;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost() 
        {
            //diz se as propriedades atuais do modelo são válidas, conforme as tags nos objetos.
            if (ModelState.IsValid) 
            {
                contexto.Add(NovoLivro);
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
