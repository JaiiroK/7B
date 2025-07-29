using _7B.Models;
using Microsoft.EntityFrameworkCore;

namespace _7B.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Report> Reports { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            =>optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BankofAmerica;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        
    }
}
