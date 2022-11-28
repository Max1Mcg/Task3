using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDB.Models;

namespace RazorPagesDB.Pages
{
    [IgnoreAntiforgeryToken]
    public class CreateModelFilm : PageModel
    {
        ApplicationContext context;
        [BindProperty]
        public Film Person { get; set; } = new();
        public CreateModelFilm(ApplicationContext db)
        {
            context = db;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            context.Films.Add(Person);
            await context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
