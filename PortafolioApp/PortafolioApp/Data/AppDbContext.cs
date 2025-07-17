using Microsoft.EntityFrameworkCore;
using PortafolioApp.Models;

namespace PortafolioApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<ProjectLink> ProjectLinks { get; set; }
    public DbSet<Certifications>  Certifications { get; set; }
    public DbSet<Jobs> Jobs { get; set; }
    
    
}