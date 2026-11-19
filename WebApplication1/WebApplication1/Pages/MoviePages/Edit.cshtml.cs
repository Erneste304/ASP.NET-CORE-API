using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Pages.MoviePages;

public class EditModel : PageModel
{
    private readonly TodoDb _context;

    public EditModel(TodoDb context)
    {
        _context = context;
    }

    [BindProperty]
    public Models.Movie Movie { get; set; } = new();

    public async Task<IActionResult> OnGetAsync(int id)
    {
        var movie = await _context.Movies.FindAsync(id);
        if (movie is null)
        {
            return NotFound();
        }

        Movie = movie;
        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int id)
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        var movie = await _context.Movies.FindAsync(id);
        if (movie is null)
        {
            return NotFound();
        }

        movie.Title = Movie.Title;
        movie.ReleaseDate = Movie.ReleaseDate;
        movie.Genre = Movie.Genre;
        movie.Price = Movie.Price;

        await _context.SaveChangesAsync();
        return RedirectToPage("./Index");
    }
}
