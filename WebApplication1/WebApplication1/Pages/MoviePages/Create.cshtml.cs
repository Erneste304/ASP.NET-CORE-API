using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages.MoviePages;

public class CreateModel : PageModel
{
    private readonly TodoDb _context;

    public CreateModel(TodoDb context)
    {
        _context = context;
    }

    [BindProperty]
    public Movie Movie { get; set; } = new();

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        Movie.Id = 0;
        _context.Movies.Add(Movie);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
