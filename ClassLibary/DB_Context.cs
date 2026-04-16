using Microsoft.EntityFrameworkCore;
using REST_DanmarksRadio.Models;

namespace ClassLibary
{
    public class DB_Context : DbContext
    {
        public DB_Context(DbContextOptions<DB_Context> options) : base(options)
        {
        }

        public DbSet<DR> DRs { get; set; }
    }
}
