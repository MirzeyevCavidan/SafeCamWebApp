using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SafeCamWebApp.Models;

namespace SafeCamWebApp.DAL.Context
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Designation> Designations { get; set; }
    }
}