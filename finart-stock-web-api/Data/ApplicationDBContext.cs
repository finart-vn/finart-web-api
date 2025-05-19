using finart_stock_web_api.Model;
using Microsoft.EntityFrameworkCore;
namespace finart_stock_web_api.Data;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    public DbSet<UserProfile> UserProfiles { get; set; }
    public DbSet<UserSettings> UserSettings { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }
    public DbSet<Comment> Comments { get; set; }
}