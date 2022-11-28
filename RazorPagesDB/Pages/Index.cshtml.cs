using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesDB.Models;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesDB.Pages
{
    public class IndexModel : PageModel
    {
        ApplicationContext context;
        public List<Film> Films { get; private set; } = new();
        public List<Category> Categories { get; private set; } = new();
        public IndexModel(ApplicationContext db)
        {
            context = db;
        }
        public void OnGet()
        {
            Categories = context.Categories.AsNoTracking().ToList();
            Films = context.Films.AsNoTracking().ToList();
        }
    }
}