using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pipeline
{
    /**Represents a book*/
    public class Book
    {

        /**Primary key for the book object*/
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /**Name of the book*/
        [Required]
        public string Name { get; set; }

        /**Author of the book*/
        [Required]
        public string Author { get; set; }

        /**Blurb of the book*/
        public string Blurb { get; set; }
    }

    /**Database context for book database*/
    class BookDb : DbContext
    {
        static readonly string connectionString = "Server=localhost; User ID=root; Password=admin; Database=book";

        public DbSet<Book> Books { get; set; } = null!;

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
