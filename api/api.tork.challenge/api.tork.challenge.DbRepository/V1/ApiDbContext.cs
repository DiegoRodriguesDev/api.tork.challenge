using api.tork.challenge.DbRepository.V1.DTOs;
using Microsoft.EntityFrameworkCore;

namespace api.tork.challenge.DbRepository.V1
{
    public class ApiDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "BooksDb");
        }
        
        public virtual DbSet<BookDto> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            string scriptPath = Path.Combine("..", "SqlFiles", "default_data.sql");
            string script = File.ReadAllText(scriptPath);
            modelBuilder.HasAnnotation("Relational:SqlScript", script);
        }
    }
}
