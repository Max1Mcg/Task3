using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesDB.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Film> Films { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}
