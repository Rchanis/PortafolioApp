using Microsoft.EntityFrameworkCore;
using PortafolioApp.Models;

namespace PortafolioApp.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<ProjectLink> ProjectLinks { get; set; }
    public DbSet<Certification>  Certifications { get; set; }
    public DbSet<Job> Jobs { get; set; }
    
    
    
}