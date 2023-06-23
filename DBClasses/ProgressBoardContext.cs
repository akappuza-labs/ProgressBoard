using Microsoft.EntityFrameworkCore;

namespace ProgressBoard.DBClasses
{
    public class ProgressBoardContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public ProgressBoardContext(DbContextOptions<ProgressBoardContext> options)
        : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                    new User
                    {
                        Id = 1,
                        FirstName = "Alexey",
                        LastName = "Kapuza",
                        Email = "akapuza1613@gmail.com",
                        Password = "hashtest",
                    },
                    new User
                    {
                        Id = 2,
                        FirstName = "TestFirstName",
                        LastName = "TestLastName",
                        Email = "testmail@testmail.com",
                        Password = "testpassword",
                    }
            );
        }

    }
}
