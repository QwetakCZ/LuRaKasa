using Microsoft.EntityFrameworkCore;
namespace WebAPILuRaKasa.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<ApplicationUser> AspNetUsers { get; set; }

    }
}
