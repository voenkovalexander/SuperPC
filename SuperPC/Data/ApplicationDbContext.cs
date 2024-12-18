using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SuperPC.Models;

namespace SuperPC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<CompletePC> CompletePCs { get; set; }
        public DbSet<Users> Users {  get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
