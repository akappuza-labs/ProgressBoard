using Microsoft.EntityFrameworkCore;
using ProgressBoardApp.Domain.Entities;

namespace ProgressBoardApp.DAL.DataAccess
{
    public class ProgressBoardContext : DbContext
    {
        public DbSet<User> Users => Set<User>();

        public ProgressBoardContext(DbContextOptions<ProgressBoardContext> options)
            : base(options)
        {
            Database.EnsureCreated(); 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();
            modelBuilder.Entity<User>()
                .Property(u => u.Email)
                .HasMaxLength(50);
            modelBuilder.Entity<User>()
                .Property(u => u.FirstName)
                .HasMaxLength(50);
            modelBuilder.Entity<User>()
                .Property(u => u.LastName)
                .HasMaxLength(50);
        }
    }
}
