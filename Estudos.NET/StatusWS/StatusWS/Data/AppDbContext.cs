using Microsoft.EntityFrameworkCore;
using StatusWS.Models;

namespace StatusWS.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<StatusType> StatusTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StatusType>().HasData(
                new StatusType { StatusTypeId = 1, Description = "Vazio", IconUrl = "https://cdn-icons-png.flaticon.com/512/4785/4785876.png" },
                new StatusType { StatusTypeId = 2, Description = "Disponível", IconUrl = "https://cdn-icons-png.flaticon.com/512/4785/4785876.png" }
            );

            modelBuilder.Entity<Status>().HasData(
                 new Status { StatusId = 1, CustomText = "Nenhum status definido", UpdateAt = DateTime.UtcNow, StatusTypeId = 1 }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}