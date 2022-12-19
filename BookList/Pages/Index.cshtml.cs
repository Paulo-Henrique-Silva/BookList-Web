using BookList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookList.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        /// <summary>
        /// Contexto do BD para a injeção de dependência
        /// </summary>
        private readonly ApplicationDbContext contexto;

        public List<Livro> LivrosLista = new();

        [BindProperty(SupportsGet = true)]
        public string TituloPesquisa { get; set; }
        
        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext contexto)
        {
            _logger = logger;
            this.contexto = contexto;
        }

        public void OnGet()
        {
            LivrosLista = contexto.Livros.ToList();
        }

        public IActionResult OnGetDeletar(int id)
        {
            contexto.Livros.Remove(contexto.Livros.Find(id));
            contexto.SaveChanges();
            return RedirectToPage("/Index");
        }

        public IActionResult OnPostPesquisarTitulo() 
        {
            if (string.IsNullOrEmpty(TituloPesquisa))
                return RedirectToPage("/Index");

            //cria uma nova lista que contenha a pesquisa especificada
            LivrosLista = contexto.Livros.Where(x => !string.IsNullOrEmpty(x.Titulo) && x.Titulo.Contains(TituloPesquisa)).ToList();

            return Page();
        }
    }
}