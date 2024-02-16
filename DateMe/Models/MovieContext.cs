using Microsoft.EntityFrameworkCore;

namespace Mission6_Stone.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base (options)
        {

        }

        public DbSet <Application> Application { get; set; }
    }
}
