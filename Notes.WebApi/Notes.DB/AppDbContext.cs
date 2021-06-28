using Microsoft.EntityFrameworkCore;

namespace Notes.DB
{
    public class AppDbContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }

        // The following configures EF to create a Sqlite database file as `C:\blogging.db`.
        // For Mac or Linux, change this to `/tmp/blogging.db` or any other absolute path.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Notes;Integrated Security=True");
        }

    }
}
