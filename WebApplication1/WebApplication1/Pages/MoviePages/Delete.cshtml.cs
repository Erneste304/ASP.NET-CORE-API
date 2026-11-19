using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Pages.MoviePages;

public class DeleteModel : PageModel
{
    private readonly TodoDb _context;

    public DeleteModel(TodoDb context)
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

    public async Task<IActionResult> OnPostAsync(int id)
    {
        var movie = await _context.Movies.FindAsync(id);
        if (movie is null)
        {
            return NotFound();
        }

        _context.Movies.Remove(movie);
        await _context.SaveChangesAsync();
        return RedirectToPage("./Index");
    }
}
