using Microsoft.EntityFrameworkCore;

namespace IndexApi.Models
{
    public class IndexContext : DbContext
    {
        public IndexContext(DbContextOptions<IndexContext> options)
            : base(options)
        {
        }

        public DbSet<IndexContext> IndexItems { get; set; }
    }
}