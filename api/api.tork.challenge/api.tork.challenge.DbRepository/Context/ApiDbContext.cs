using api.tork.challenge.DbRepository.V1.DTOs;
using Microsoft.EntityFrameworkCore;

namespace api.tork.challenge.DbRepository.Context
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext() : base() { }
        
        public virtual DbSet<BookDto> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Integrated Security=True;Initial Catalog=TempDB;Integrated Security=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}