using APIDemo161024.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo211024_Template.DatabaseConnection
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        public DbSet<Book> Book { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "The Great Gatsby",
                    Description = "A novel written by American author F. Scott Fitzgerald.",
                    Price = 10.99,
                    Quantity = 100
                },
                new Book
                {
                    Id = 2,
                    Title = "1984",
                    Description = "A dystopian social science fiction novel and cautionary tale, written by the English writer George Orwell.",
                    Price = 8.99,
                    Quantity = 150
                },
                new Book
                {
                    Id = 3,
                    Title = "To Kill a Mockingbird",
                    Description = "A novel by Harper Lee published in 1960.",
                    Price = 12.99,
                    Quantity = 200
                }
            );
        }

    }
}
