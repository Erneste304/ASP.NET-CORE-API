using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1;

namespace WebApplication1.Pages.MoviePages
{
    public class IndexModel : PageModel
    {
        private readonly TodoDb _context;

        public IndexModel(TodoDb context)
        {
            _context = context;
        }

        public IList<Movie> Movies { get; private set; } = [];

        public async Task OnGetAsync()
        {
            Movies = await _context.Movies.OrderBy(movie => movie.Title).ToListAsync();
        }
    }
}