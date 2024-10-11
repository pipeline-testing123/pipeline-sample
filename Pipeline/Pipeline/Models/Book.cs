using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pipeline.Models
{
    public class Book
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Author { get; set; }

        public string Blurb { get; set; }
    }

    class BookDb : DbContext
    {
        static readonly string connectionString = "Server=localhost; User ID=root; Password=admin; Database=book";

        public DbSet<Book> Petitions { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
            .HasData(
                    new Book { Id = 1, Name = "The Very Hungry Caterpillar", Author="Eric Carle", Blurb = "A book about a caterpillar, I think." },
                    new Book { Id = 2, Name = "The Witches", Author="Roald Dahl", Blurb = "A book about witches." },
                    new Book { Id = 3, Name = "The Hobbit", Author="J.R.R Tolkien", Blurb = "A book about a hobbit." }
            );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }
    }
}
