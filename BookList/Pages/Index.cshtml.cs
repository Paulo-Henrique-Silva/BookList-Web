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

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext contexto)
        {
            _logger = logger;
            this.contexto = contexto;
        }

        public void OnGet()
        {
            LivrosLista = contexto.Livros.ToList();
        }
    }
}