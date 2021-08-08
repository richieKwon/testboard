
using Microsoft.EntityFrameworkCore;
using testboard.Models;

namespace testboard.DataContext
{
    public class AspnetNoteDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        
        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=localhost;Database=Test.board3.Db;User Id=sa;Password=Complicated1234;");
            
        }
    }
}