using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Pages.MoviePages;

public class DetailsModel : PageModel
{
    private readonly TodoDb _context;

    public DetailsModel(TodoDb context)
    {
        _context = context;
    }

    public Movie Movie { get; private set; } = new();

    public async Task<IActionResult> OnGetAsync(int id)
    {
        var movie = await _context.Movies.AsNoTracking().FirstOrDefaultAsync(item => item.Id == id);
        if (movie is null)
        {
            return NotFound();
        }

        Movie = movie;
        return Page();
    }
}
