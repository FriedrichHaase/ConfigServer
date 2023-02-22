using Microsoft.EntityFrameworkCore;

namespace TestConfigServer
{
    public class ApplicationUser : DbContext
    {
        public ApplicationUser(DbContextOptions<ApplicationUser> options) : base(options)
        {

        }
        public DbSet<User> UserRegistration { get; set; }
    }
}
