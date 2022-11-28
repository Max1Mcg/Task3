using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDB.Models;

namespace RazorPagesDB.Pages
{
    [IgnoreAntiforgeryToken]
    public class CreateModelCategories : PageModel
    {
        ApplicationContext context;
        [BindProperty]
        public Category Person { get; set; } = new();
        public CreateModelCategories(ApplicationContext db)
        {
            context = db;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            context.Categories.Add(Person);
            await context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
