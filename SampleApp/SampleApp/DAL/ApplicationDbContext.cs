using SampleApp.Models;

namespace SampleApp.DAL;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    // Tutaj możesz dodać dodatkowe DbSety dla innych modeli
    // public DbSet<OtherModel> OtherModels { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        // Zmiana nazwy tabeli
        builder.Entity<ApplicationUser>().ToTable("MyUsers");
    
        // Zmiana nazwy właściwości/kolumny
        builder.Entity<ApplicationUser>()
            .Property(u => u.UserName)
            .HasColumnName("Login");
    }
}